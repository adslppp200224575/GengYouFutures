#pragma once

#include <array>
#include <deque>
#include <iostream>
#include <map>
#include <string>
#include <unordered_map>

#include "SKCOM_reference.h"
#include "TEventHandler.h"
#include "config.h"

#define COMMODITY_OS_MAIN "CME,NQ0000"

class CSKOSQuoteLib
{
public:
    typedef TEventHandlerNamespace::TEventHandler<CSKOSQuoteLib, SKCOMLib::ISKOSQuoteLib, SKCOMLib::_ISKOSQuoteLibEvents> ISKOSQuoteLibEventHandler;

    CSKOSQuoteLib();
    ~CSKOSQuoteLib();

    // Methods
    long EnterMonitorLONG();
    long IsConnected();
    long LeaveMonitor();
    long RequestStocks(short *psPageNo, string strStockNos);
    long RequestTicks(short *psPageNo, string strStockNos);
    long RequestStockList(short MarketNo);
    long GetStockByIndexLONG(long bStockIndex, SKCOMLib::SKFOREIGNLONG *pSKStock);
    long RequestKLine(string strStockNo);
    long RequestServerTime();
    long RequestStockIndexMap(IN string strStockNo, OUT SKCOMLib::SKFOREIGNLONG *pSKStock);
    long GetMarketBuySellUpDown(VOID);
    void ProcessDaysOrNightCommHighLowPoint();
    VOID GetCommodityIdx(VOID);

    // Events
    void OnConnection(long nKind, long nCode);
    void OnNotifyQuoteLONG(short sMarketNo, long nStockIndex);
    void OnNotifyTicksLONG(long nStockIndex, long nPtr, long nDate, long lTimehms, long nBid, long nAsk, long nClose, long nQty, long nSimulate);
    void OnNotifyTicksNineDigitLONG(long nStockIndex, long nPtr, long nDate, long lTimehms, long nBid, long nAsk, long nClose, long nQty, long nSimulate);
    void OnNotifyBest5LONG(
        SHORT sMarketNo, LONG nStockidx,
        long nBestBid1, long nBestBidQty1,
        long nBestBid2, long nBestBidQty2,
        long nBestBid3, long nBestBidQty3,
        long nBestBid4, long nBestBidQty4,
        long nBestBid5, long nBestBidQty5,
        LONG nExtendBid, LONG nExtendBidQty,
        long nBestAsk1, long nBestAskQty1,
        long nBestAsk2, long nBestAskQty2,
        long nBestAsk3, long nBestAskQty3,
        long nBestAsk4, long nBestAskQty4,
        long nBestAsk5, long nBestAskQty5,
        LONG nExtendAsk, LONG nExtendAskQty,
        LONG nSimulate);

    void OnNotifyStockList(long sMarketNo, string strStockData);
    void OnNotifyKLineData(BSTR bstrStockNo, BSTR bstrData);
    void OnNotifyServerTime(SHORT sHour, SHORT sMinute, SHORT sSecond, LONG nTotal);
    void OnNotifyMarketTot(SHORT sMarketNo, SHORT sPtr, LONG nTime, LONG nTotv, LONG nTots, LONG nTotc);
    void OnNotifyMarketBuySell(SHORT sMarketNo, SHORT sPtr, LONG nTime, LONG nBc, LONG nSc, LONG nBs, LONG nSs);

private:
    HRESULT OnEventFiringObjectInvoke(
        ISKOSQuoteLibEventHandler *pEventHandler,
        DISPID dispidMember,
        REFIID riid,
        LCID lcid,
        WORD wFlags,
        DISPPARAMS *pdispparams,
        VARIANT *pvarResult,
        EXCEPINFO *pexcepinfo,
        UINT *puArgErr);

    SKCOMLib::ISKOSQuoteLibPtr m_pSKOSQuoteLib;
    ISKOSQuoteLibEventHandler *m_pSKOSQuoteLibEventHandler;
};

VOID GetCommodityIdx(VOID);
void loadHighLowPoints();
void updateHighLowPoints(const std::string &date, double dayHigh, double dayLow, double nightHigh, double nightLow);

extern std::unordered_map<long, std::array<long, 6>> gTransactionList;
// long nPtr, long nBid, long nAsk, long nClose, long nQty
