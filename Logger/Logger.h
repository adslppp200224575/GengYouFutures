#ifndef LOGGER_H
#define LOGGER_H

#include <fstream>
#include <sstream>
#include <string>
#include <iomanip>   // for std::hex
#include <stdexcept> // for std::runtime_error

#ifndef NDEBUG
#define LOGGING_ENABLED
#define ENABLE_DEBUG
#endif

class Logger
{
public:
    Logger(const std::string &filename);
    ~Logger();

    void log(const std::string &message, const std::string &functionName);

    template <typename... Args>
    void log(const std::string &functionName, const char *format, Args... args)
    {
#ifdef LOGGING_ENABLED
        if (logFile.is_open())
        {
            std::ostringstream oss;
            format_string(oss, format, args...);
            logFile << "[" << functionName << "] " << oss.str() << std::endl;
        }
#endif
    }

private:
    std::ofstream logFile;

    void format_string(std::ostringstream &oss, const char *format)
    {
        while (*format != '\0')
        {
            if (*format == '%' && (*(format + 1) == 's' || *(format + 1) == 'd' || *(format + 1) == 'x' || *(format + 1) == 'l'))
            {
                // handle case where format specifier is not followed by any argument
                throw std::runtime_error("Too few arguments for format string");
            }
            oss << *format++;
        }
    }

    template <typename T, typename... Args>
    void format_string(std::ostringstream &oss, const char *format, T value, Args... args)
    {
        while (*format != '\0')
        {
            if (*format == '%' && *(format + 1) == 's')
            {
                oss << value;
                format += 2;
                format_string(oss, format, args...);
                return;
            }
            else if (*format == '%' && *(format + 1) == 'd')
            {
                oss << std::dec << value;
                format += 2;
                format_string(oss, format, args...);
                return;
            }
            else if (*format == '%' && *(format + 1) == 'x')
            {
                oss << std::hex << value;
                format += 2;
                format_string(oss, format, args...);
                return;
            }
            else if (*format == '%' && *(format + 1) == 'l' && *(format + 2) == 'd')
            {
                if constexpr (std::is_same_v<T, long>)
                {
                    oss << std::dec << value;
                }
                else
                {
                    throw std::runtime_error("Invalid type for %ld format specifier");
                }
                format += 3;
                format_string(oss, format, args...);
                return;
            }
            else
            {
                oss << *format++;
            }
        }
    }
};

#if !defined(NDEBUG) && defined(ENABLE_DEBUG)
#define DEBUG(...)                         \
    do                                     \
    {                                      \
        logger.log(__func__, __VA_ARGS__); \
    } while (0)
#else
#define DEBUG(...)
#endif

extern Logger logger;

#endif // LOGGER_H
