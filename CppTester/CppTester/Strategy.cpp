#include "Strategy.h"
#include "SKCenterLib.h"
#include "SKOrderLib.h"
#include "SKQuoteLib.h"
#include "SKReplyLib.h"
#include <Logger.h>
#include <array>
#include <chrono>  // For std::chrono::steady_clock
#include <conio.h> // For kbhit() and _getch()
#include <cstdlib> // For system("cls")
#include <deque>
#include <iostream>
#include <thread> // For std::this_thread::sleep_for
#include <unordered_map>

// Define the global logger instance
Logger StrategyLog("Strategy.log");

// Object pointer

extern CSKCenterLib *pSKCenterLib;
extern CSKQuoteLib *pSKQuoteLib;
extern CSKReplyLib *pSKReplyLib;
extern CSKOrderLib *pSKOrderLib;

// Global variables, initialized by main, and continuously updated by the com server
extern SHORT gCurServerTime[3];
extern std::unordered_map<SHORT, std::array<long, 4>> gCurTaiexInfo;
extern std::deque<long> gDaysKlineDiff;
extern std::deque<long> gCostMovingAverage;
extern std::unordered_map<long, std::array<long, 3>> gCurCommHighLowPoint;
extern std::unordered_map<long, long> gCurCommPrice;
extern std::unordered_map<long, vector<pair<long, long>>> gBest5BidOffer;

extern OpenInterestInfo gOpenInterestInfo;

extern string g_strUserId;

extern COMMODITY_INFO gCommodtyInfo;

DAY_AMP_AND_KEY_PRICE gDayAmpAndKeyPrice = {0};
BID_OFFER_LONG_AND_SHORT gBidOfferLongAndShort = {0};
LONG gBidOfferLongShort = 0;
double gCostMovingAverageVal = 0;

void AutoKLineData(IN string ProductNum)
{
    DEBUG(DEBUG_LEVEL_DEBUG, "Started");

    long g_nCode = pSKQuoteLib->RequestKLine(ProductNum);

    DEBUG(DEBUG_LEVEL_DEBUG, "g_nCode=%ld", g_nCode);

    pSKCenterLib->PrintfCodeMessage("Quote", "RequestKLine", g_nCode);

    DEBUG(DEBUG_LEVEL_DEBUG, "end");
}

DOUBLE CountCostMovingAverage(VOID)
{
    if (gCostMovingAverageVal == 0)
    {
        double count = 0;
        double LocalCostMovingAverageVal = 0;

        for (auto &Avg : gCostMovingAverage)
        {
            DEBUG(DEBUG_LEVEL_INFO, "Avg = %ld", Avg);

            ++count;

            LocalCostMovingAverageVal += static_cast<double>(Avg);
        }

        if (count != 0)
        {
            LocalCostMovingAverageVal /= count;
        }

        DEBUG(DEBUG_LEVEL_INFO, "LocalCostMovingAverageVal = %f", LocalCostMovingAverageVal);

        gCostMovingAverageVal = LocalCostMovingAverageVal;
    }

    double curPrice = 0;

    if (gCurCommPrice.count(gCommodtyInfo.MTXIdxNo) != 0)
    {
        curPrice = static_cast<double>(gCurCommPrice[gCommodtyInfo.MTXIdxNo]) / 100.0;
    }

    if (curPrice != 0)
    {
        return (gCostMovingAverageVal + curPrice) / 2.0;
    }

    return gCostMovingAverageVal;
}

VOID AutoCalcuKeyPrices(LONG nStockidx)
{
    if (gDaysKlineDiff.size() < 20)
    {
        AutoKLineData(COMMODITY_TX_MAIN);

        pSKQuoteLib->ProcessDaysOrNightCommHighLowPoint();

        long accu = 0;
        long AvgAmp = 0, LargestAmp = LONG_MIN, SmallestAmp = LONG_MAX, LargerAmp = 0, SmallAmp = 0;

        for (int i = 0; i < gDaysKlineDiff.size(); ++i)
        {
            DEBUG(DEBUG_LEVEL_INFO, "Diff = %ld ", gDaysKlineDiff[i]);

            accu += gDaysKlineDiff[i];

            LargestAmp = max(LargestAmp, gDaysKlineDiff[i]);
            SmallestAmp = min(SmallestAmp, gDaysKlineDiff[i]);
        }

        AvgAmp = accu / DayMA;

        LargerAmp = (AvgAmp + LargestAmp) / 2;
        SmallAmp = (AvgAmp + SmallestAmp) / 2;

        DEBUG(DEBUG_LEVEL_INFO, "SmallestAmp : %ld", SmallestAmp);
        DEBUG(DEBUG_LEVEL_INFO, "SmallAmp : %ld", SmallAmp);
        DEBUG(DEBUG_LEVEL_INFO, "AvgAmp : %ld", AvgAmp);
        DEBUG(DEBUG_LEVEL_INFO, "LargerAmp : %ld", LargerAmp);
        DEBUG(DEBUG_LEVEL_INFO, "LargestAmp : %ld", LargestAmp);

        gDayAmpAndKeyPrice.SmallestAmp = SmallestAmp;
        gDayAmpAndKeyPrice.SmallAmp = SmallAmp;
        gDayAmpAndKeyPrice.AvgAmp = AvgAmp;
        gDayAmpAndKeyPrice.LargerAmp = LargerAmp;
        gDayAmpAndKeyPrice.LargestAmp = LargestAmp;
    }

    if (gCurCommHighLowPoint.count(nStockidx) > 0)
    {
        long CurHigh = gCurCommHighLowPoint[nStockidx][0] / 100;
        long CurLow = gCurCommHighLowPoint[nStockidx][1] / 100;

        DEBUG(DEBUG_LEVEL_DEBUG, "MTXIdxNo: %ld. High: %ld, Low: %ld", nStockidx, CurHigh, CurLow);

        gDayAmpAndKeyPrice.LongKey5 = CurLow + gDayAmpAndKeyPrice.LargestAmp;
        gDayAmpAndKeyPrice.LongKey4 = CurLow + gDayAmpAndKeyPrice.LargerAmp;
        gDayAmpAndKeyPrice.LongKey3 = CurLow + gDayAmpAndKeyPrice.AvgAmp;
        gDayAmpAndKeyPrice.LongKey2 = CurLow + gDayAmpAndKeyPrice.SmallAmp;
        gDayAmpAndKeyPrice.LongKey1 = CurLow + gDayAmpAndKeyPrice.SmallestAmp;

        gDayAmpAndKeyPrice.ShortKey5 = CurHigh - gDayAmpAndKeyPrice.LargestAmp;
        gDayAmpAndKeyPrice.ShortKey4 = CurHigh - gDayAmpAndKeyPrice.LargerAmp;
        gDayAmpAndKeyPrice.ShortKey3 = CurHigh - gDayAmpAndKeyPrice.AvgAmp;
        gDayAmpAndKeyPrice.ShortKey2 = CurHigh - gDayAmpAndKeyPrice.SmallAmp;
        gDayAmpAndKeyPrice.ShortKey1 = CurHigh - gDayAmpAndKeyPrice.SmallestAmp;
    }

    CountCostMovingAverage();
}

/**
 * @brief
 *
 * struct FUTUREORDER
{
    BSTR bstrFullAccount; // Full account number, branch code + 7-digit account number
    BSTR bstrStockNo;     // Future option code
    SHORT sTradeType;     // 0: ROD, 1: IOC, 2: FOK
    SHORT sBuySell;       // 0: Buy, 1: Sell
    SHORT sDayTrade;      // Day trade, 0: No, 1: Yes. Refer to exchange regulations for tradable items.
    SHORT sNewClose;      // New position or close position, 0: New position, 1: Close position, 2: Auto (used for new futures and options)
    BSTR bstrPrice;       // Order price (for IOC and FOK, use "M" for market price, "P" for range market price)
    LONG nQty;            // Number of contracts
    SHORT sReserved;      // {For SendFutureOrderCLR futures order} Trading session, 0: Intraday (T session and T+1 session), 1: T session reservation
};

 * long CSKOrderLib::SendFutureOrder(
 * string strLogInID,
 * bool bAsyncOrder,
 * string strStockNo,
 * short sTradeType,
 * short sBuySell,
 * short sDayTrade,
 * short sNewClose,
 * string strPrice,
 * long nQty,
 * short sReserved)
 * @param[in]
 * @param[in]
 * @return
 * @exception
 */

LONG AutoOrder(IN string ProductNum, IN SHORT NewClose, IN SHORT BuySell)
{
    DEBUG(DEBUG_LEVEL_DEBUG, "Started");

    long g_nCode = pSKOrderLib->SendFutureOrder(g_strUserId,
                                                false, // bAsyncOrder
                                                ProductNum,
                                                1,        // IOC
                                                BuySell,  // BuySell
                                                0,        // DayTrade
                                                NewClose, // New position or close position, 0: New position, 1: Close position, 2: Auto (used for new futures and options)
                                                "P",
                                                1,
                                                0);

    pSKCenterLib->PrintfCodeMessage("AutoOrder", "SendFutureOrder", g_nCode);

    LOG(DEBUG_LEVEL_INFO, "SendFutureOrder res = %d, ProductNum=%s, NewClose=%d, BuySell=%d",
        g_nCode, ProductNum, NewClose, BuySell);

    DEBUG(DEBUG_LEVEL_DEBUG, "end");

    return g_nCode;
}

VOID StrategyStopFuturesLoss(string strUserId)
{
    DEBUG(DEBUG_LEVEL_DEBUG, "Start");

    // if over loss then do GetOpenInterest again in order to make sure
    // AutoOrder wont place a closing order with the wrong amount
    // else continue to calculate profit and loss and update to global variables
    double profitAndLoss = 0;
    double curPrice = 0;

    if (TEST_MODE == 0)
    {
        long res = pSKOrderLib->GetOpenInterest(strUserId, 1);

        if (res != 0)
        {
            DEBUG(DEBUG_LEVEL_DEBUG, "pSKOrderLib->GetOpenInterest(strUserId, 1)=%ld", res);
        }
    }

    if (gCurCommPrice.count(gCommodtyInfo.MTXIdxNo) != 0)
    {
        curPrice = static_cast<double>(gCurCommPrice[gCommodtyInfo.MTXIdxNo]) / 100.0;
    }

    if (gOpenInterestInfo.product != "" && gOpenInterestInfo.avgCost != 0 && curPrice > 0)
    {
        LOG(DEBUG_LEVEL_DEBUG, "product: %s", gOpenInterestInfo.product);
        LOG(DEBUG_LEVEL_DEBUG, "buySell: %s", gOpenInterestInfo.buySell);
        LOG(DEBUG_LEVEL_DEBUG, "openPosition: %ld", gOpenInterestInfo.openPosition);
        LOG(DEBUG_LEVEL_DEBUG, "dayTradePosition: %ld", gOpenInterestInfo.dayTradePosition);
        LOG(DEBUG_LEVEL_DEBUG, "avgCost: %f", gOpenInterestInfo.avgCost);

        SHORT CloseBuySell = -1;

        if (gOpenInterestInfo.buySell == "S")
        {
            profitAndLoss = (gOpenInterestInfo.avgCost - curPrice) * DOLLARS_PER_TICK;
            CloseBuySell = 0; // short position
        }
        else if (gOpenInterestInfo.buySell == "B")

        {
            profitAndLoss = (curPrice - gOpenInterestInfo.avgCost) * DOLLARS_PER_TICK;
            CloseBuySell = 1; // long position
        }

        gOpenInterestInfo.profitAndLoss = profitAndLoss;

        LOG(DEBUG_LEVEL_DEBUG, "curPrice = %f, gOpenInterestInfo.avgCost= %f, profit and loss:%f",
            curPrice, gOpenInterestInfo.avgCost, profitAndLoss);

        if (-profitAndLoss >= MAXIMUM_LOSS)
        {
            LOG(DEBUG_LEVEL_INFO, "STOP Loss at curPrice = %f, gOpenInterestInfo.avgCost= %f, profit and loss:%f",
                curPrice, gOpenInterestInfo.avgCost, profitAndLoss);

            vector<string> vec = {COMMODITY_MAIN, COMMODITY_OTHER};

            for (auto &x : vec)
            {
                AutoOrder(x,
                          ORDER_CLOSE_POSITION, // Close
                          CloseBuySell          // Buy or sell
                );
            }

            if (TEST_MODE == 1)
            {
                gOpenInterestInfo = {
                    "", // product
                    "", // Buy/Sell Indicator
                    0,  // openPosition 0
                    0,  // dayTradePosition 0
                    0.0 // avgCost 0.0
                };
            }
        }
    }

    DEBUG(DEBUG_LEVEL_DEBUG, "End");
}

VOID StrategyClosePosition(string strUserId)
{
    DEBUG(DEBUG_LEVEL_DEBUG, "Start");

    double curPrice = 0;

    if (gCurCommPrice.count(gCommodtyInfo.MTXIdxNo) != 0)
    {
        curPrice = static_cast<double>(gCurCommPrice[gCommodtyInfo.MTXIdxNo]) / 100.0;
    }

    if (gOpenInterestInfo.product != "" && gOpenInterestInfo.avgCost != 0 && curPrice > 0)
    {
        LOG(DEBUG_LEVEL_DEBUG, "product: %s", gOpenInterestInfo.product);
        LOG(DEBUG_LEVEL_DEBUG, "buySell: %s", gOpenInterestInfo.buySell);
        LOG(DEBUG_LEVEL_DEBUG, "openPosition: %ld", gOpenInterestInfo.openPosition);
        LOG(DEBUG_LEVEL_DEBUG, "dayTradePosition: %ld", gOpenInterestInfo.dayTradePosition);
        LOG(DEBUG_LEVEL_DEBUG, "avgCost: %f", gOpenInterestInfo.avgCost);

        LOG(DEBUG_LEVEL_DEBUG, "curPrice = %f, gOpenInterestInfo.avgCost= %f",
            curPrice, gOpenInterestInfo.avgCost);

        SHORT CloseBuySell = -1, BuySell = -1;

        if (gOpenInterestInfo.buySell == "S")
        {
            BuySell = 1;
            CloseBuySell = 0; // short position
        }
        else if (gOpenInterestInfo.buySell == "B")
        {
            BuySell = 0;
            CloseBuySell = 1; // long position
        }

        if ((BuySell == 0 && gDayAmpAndKeyPrice.LongKey2 > 0 && curPrice >= gDayAmpAndKeyPrice.LongKey2) ||
            (BuySell == 1 && gDayAmpAndKeyPrice.ShortKey2 > 0 && curPrice <= gDayAmpAndKeyPrice.ShortKey2))
        {
            vector<string> vec = {COMMODITY_OTHER};

            for (auto &x : vec)
            {
                AutoOrder(x,
                          ORDER_CLOSE_POSITION, // Close
                          CloseBuySell          // Buy or sell
                );
            }
        }
    }

    DEBUG(DEBUG_LEVEL_DEBUG, "End");
}

VOID StrategyNewLongShortPosition(string strUserId, LONG LongShort)
{
    DEBUG(DEBUG_LEVEL_DEBUG, "Start");

    double OpenPrice = 0;

    if (gCurCommHighLowPoint.count(gCommodtyInfo.MTXIdxNo) == 0)
    {
        return;
    }
    else
    {
        OpenPrice = static_cast<double>(gCurCommHighLowPoint[gCommodtyInfo.MTXIdxNo][2]) / 100.0;
    }

    double curPrice = 0;

    if (gCurCommPrice.count(gCommodtyInfo.MTXIdxNo) != 0)
    {
        curPrice = static_cast<double>(gCurCommPrice[gCommodtyInfo.MTXIdxNo]) / 100.0;
    }

    double CurAmp = 0;

    if (gCurCommHighLowPoint.count(gCommodtyInfo.MTXIdxNo) > 0)
    {
        double CurHigh = gCurCommHighLowPoint[gCommodtyInfo.MTXIdxNo][0] / 100.0;
        double CurLow = gCurCommHighLowPoint[gCommodtyInfo.MTXIdxNo][1] / 100.0;
        CurAmp = CurHigh - CurLow;
    }

    if (LongShort == 1 && gOpenInterestInfo.openPosition <= 0)
    {
        DEBUG(DEBUG_LEVEL_DEBUG, "curPrice = %f, gOpenInterestInfo.avgCost= %f",
              curPrice, gOpenInterestInfo.avgCost);

        SHORT BuySell = -1;

        if (gDayAmpAndKeyPrice.LongKey1 > 0 &&
            curPrice >= gCostMovingAverageVal + ACTIVITY_POINT &&
            curPrice <= gDayAmpAndKeyPrice.LongKey1 + ACTIVITY_POINT &&
            CurAmp <= gDayAmpAndKeyPrice.SmallAmp)
        {
            BuySell = 0; // Long position

            LOG(DEBUG_LEVEL_INFO, "New Long position, curPrice = %f, gCostMovingAverageVal= %f",
                curPrice, gCostMovingAverageVal);

            vector<string> vec = {COMMODITY_OTHER};

            for (auto &x : vec)
            {
                AutoOrder(x,
                          ORDER_CLOSE_POSITION, // Close
                          BuySell               // Buy or sell
                );
            }

            {
                gOpenInterestInfo.product = COMMODITY_OTHER;
                gOpenInterestInfo.buySell = "B";
                gOpenInterestInfo.openPosition += 1;
                gOpenInterestInfo.avgCost = curPrice;
            }
        }
    }

    if (LongShort == 0 && gOpenInterestInfo.openPosition >= 0)
    {
        DEBUG(DEBUG_LEVEL_DEBUG, "curPrice = %f, gOpenInterestInfo.avgCost= %f",
              curPrice, gOpenInterestInfo.avgCost);

        SHORT BuySell = -1;

        if (gDayAmpAndKeyPrice.ShortKey1 > 0 &&
            curPrice <= gCostMovingAverageVal - ACTIVITY_POINT &&
            curPrice >= gDayAmpAndKeyPrice.ShortKey1 - ACTIVITY_POINT &&
            CurAmp <= gDayAmpAndKeyPrice.SmallAmp)
        {

            BuySell = 1; // Short position

            LOG(DEBUG_LEVEL_INFO, "New Short position, curPrice = %f, gCostMovingAverageVal= %f",
                curPrice, gCostMovingAverageVal);

            vector<string> vec = {COMMODITY_OTHER};

            for (auto &x : vec)
            {
                AutoOrder(x,
                          ORDER_CLOSE_POSITION, // Close
                          BuySell               // Buy or sell
                );
            }

            {
                gOpenInterestInfo.product = COMMODITY_OTHER;
                gOpenInterestInfo.buySell = "S";
                gOpenInterestInfo.openPosition -= 1;
                gOpenInterestInfo.avgCost = curPrice;
            }
        }
    }

    DEBUG(DEBUG_LEVEL_DEBUG, "End");
}

LONG CountBidOfferLongShort(LONG nStockidx)
{
    if (gCurServerTime[0] < 9 || (gCurServerTime[0] >= 13 && gCurServerTime[1] >= 30) || gCurServerTime[0] >= 14)
    {
        return 0;
    }

    long countLong = 0, countShort = 0;

    long totalBid = 0;

    for (int i = 0; i < 5; ++i)
    {
        totalBid += gBest5BidOffer[nStockidx][i].second;
    }

    long totalOffer = 0;

    for (int i = 5; i < 10; ++i)
    {
        totalOffer += gBest5BidOffer[nStockidx][i].second;
    }

    if (totalBid * 2 <= totalOffer)
    {
        ++countLong;
    }

    if (totalOffer * 2 <= totalBid)
    {
        --countShort;
    }

    LOG(DEBUG_LEVEL_DEBUG, "countLong = %ld, countShort=%ld", countLong, countShort);

    return countLong + countShort;
}

LONG StrategyCaluBidOfferLongShort(VOID)
{
    DEBUG(DEBUG_LEVEL_DEBUG, "Start");

    if (gBidOfferLongShort >= INT_MAX || gBidOfferLongShort < INT_MIN)
    {
        return gBidOfferLongShort;
    }

    // long MTXIdxNo;
    // long MTXIdxNoAM;
    // long TSMCIdxNo;
    // long HHIdxNo;
    // long TSEAIdxNo;

    if (gCommodtyInfo.TSMCIdxNo != 0)
    {
        long nStockidx = gCommodtyInfo.TSMCIdxNo;

        gBidOfferLongShort += CountBidOfferLongShort(nStockidx);
    }

    if (gCommodtyInfo.HHIdxNo != 0)
    {
        long nStockidx = gCommodtyInfo.HHIdxNo;

        gBidOfferLongShort += CountBidOfferLongShort(nStockidx);
    }

    LOG(DEBUG_LEVEL_DEBUG, "LongShort = %ld", gBidOfferLongShort);

    DEBUG(DEBUG_LEVEL_DEBUG, "End");

    return gBidOfferLongShort;
}

VOID StrategyNewIntervalAmpLongShortPosition(string strUserId, LONG LongShort)
{
    DEBUG(DEBUG_LEVEL_DEBUG, "Start");

    double CurAmp = 0;

    if (gCurCommHighLowPoint.count(gCommodtyInfo.MTXIdxNo) == 0)
    {
        return;
    }
    else
    {
        CurAmp = static_cast<double>(gCurCommHighLowPoint[gCommodtyInfo.MTXIdxNo][0]) / 100.0 -
                 static_cast<double>(gCurCommHighLowPoint[gCommodtyInfo.MTXIdxNo][1]) / 100.0;
    }

    double curPrice = 0;

    if (gCurCommPrice.count(gCommodtyInfo.MTXIdxNo) != 0)
    {
        curPrice = static_cast<double>(gCurCommPrice[gCommodtyInfo.MTXIdxNo]) / 100.0;
    }

    BOOL IntervalAmpKStickMatch = FALSE;

    if (CurAmp <= gDayAmpAndKeyPrice.AvgAmp)
    {
        IntervalAmpKStickMatch = TRUE;
    }
    else
    {
        return;
    }

    if (curPrice > 0)
    {
        DEBUG(DEBUG_LEVEL_DEBUG, "curPrice = %f, gOpenInterestInfo.avgCost= %f",
              curPrice, gOpenInterestInfo.avgCost);

        SHORT BuySell = -1;

        if (LongShort == 1 && gOpenInterestInfo.openPosition <= 0)
        {
            if (gDayAmpAndKeyPrice.ShortKey2 > 0 && curPrice <= gDayAmpAndKeyPrice.ShortKey2 && curPrice >= gDayAmpAndKeyPrice.ShortKey1 - ACTIVITY_POINT)
            {
                BuySell = 0; // Long position
            }
        }
        else if (LongShort == 0 && gOpenInterestInfo.openPosition >= 0)
        {
            if (gDayAmpAndKeyPrice.LongKey2 > 0 && curPrice >= gDayAmpAndKeyPrice.LongKey2 && curPrice <= gDayAmpAndKeyPrice.LongKey2 + ACTIVITY_POINT)
            {
                BuySell = 1; // Short position
            }
        }

        if (BuySell != -1)
        {
            vector<string> vec = {COMMODITY_OTHER};

            for (auto &x : vec)
            {
                AutoOrder(x,
                          ORDER_CLOSE_POSITION, // Close
                          BuySell               // Buy or sell
                );
            }

            {
                gOpenInterestInfo.product = COMMODITY_OTHER;

                if (BuySell == 1)
                {
                    gOpenInterestInfo.buySell = "S";
                    gOpenInterestInfo.openPosition -= 1;

                    LOG(DEBUG_LEVEL_INFO, "New Short position, curPrice = %f",
                        curPrice);
                }

                if (BuySell == 0)
                {
                    gOpenInterestInfo.buySell = "B";
                    gOpenInterestInfo.openPosition += 1;

                    LOG(DEBUG_LEVEL_INFO, "New Long position, curPrice = %f",
                        curPrice);
                }

                gOpenInterestInfo.avgCost = curPrice;
            }
        }
    }

    DEBUG(DEBUG_LEVEL_DEBUG, "End");
}
