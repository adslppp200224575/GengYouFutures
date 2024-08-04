#pragma once

#include "SKCOM_reference.h"
#include "TEventHandler.h"
#include <iostream>
#include <string>
#include <vector>

using namespace std;

class CSKOrderLib
{
public:
    typedef TEventHandlerNamespace::TEventHandler<CSKOrderLib, SKCOMLib::ISKOrderLib, SKCOMLib::_ISKOrderLibEvents> ISKOrderLibEventHandler;

    CSKOrderLib();
    ~CSKOrderLib();

    // Methods
    long Initialize();
    long GetUserAccount();
    long GetFutureRights(string strLogInID);
    long ReadCertByID(string strLogInID);
    long SendStockOrder(string strLogInID, bool bAsyncOrder, string strStockNo, short sPrime, short sPeriod, short sFlag, short sBuySell, string strPrice, long nQty, long nTradeType, long nSpecialTradeType);
    long SendFutureOrder(string strLogInID, bool bAsyncOrder, string strStockNo, short sTradeType, short sBuySell, short sDayTrade, short sNewClose, string strPrice, long nQty, short sReserved);
    long SendFutureStop(string strLogInID,
                        bool bAsyncOrder,
                        string strStockNo,
                        short sTradeType,
                        short sBuySell,
                        short sDayTrade,
                        short sNewClose,
                        string strPrice,
                        string strTrigger,
                        long nQty,
                        short sReserved);
    long SendOptionOrder(string strLogInID, bool bAsyncOrder, string strStockNo, short sTradeType, short sBuySell, short sDayTrade, short sNewClose, string strPrice, long nQty, short sReserved);

    long DecreaseOrder(string strLogInID, bool bAsyncOrder, int nMarket, string strNo, long nDecreaseQty);
    long CorrectPrice(string strLogInID, bool bAsyncOrder, int nMarket, int nType, string strNo, string strPrice, long nTradeType);
    long CancelOrder(string strLogInID, bool bAsyncOrder, int nMarket, int nType, string strNo);

    // GetOpenInterestGW

    // Event
    void OnAccount(string strLoginID, string strAccountData);
    void OnAsyncOrder(long nThreadID, long nCode, string strMessage);

    void OnFutureRights(BSTR bstrData);

    // OnOpenInterest

private:
    HRESULT OnEventFiringObjectInvoke(
        ISKOrderLibEventHandler *pEventHandler,
        DISPID dispidMember,
        REFIID riid,
        LCID lcid,
        WORD wFlags,
        DISPPARAMS *pdispparams,
        VARIANT *pvarResult,
        EXCEPINFO *pexcepinfo,
        UINT *puArgErr);

    SKCOMLib::ISKOrderLibPtr m_pSKOrderLib;
    ISKOrderLibEventHandler *m_pSKOrderLibEventHandler;

    vector<string> vec_strFullAccount_TS;
    vector<string> vec_strFullAccount_TF;
    vector<string> vec_strFullAccount_OF;
};

// struct FUTUREORDER
// {
//     BSTR bstrFullAccount;
//     BSTR bstrStockNo;
//     BSTR bstrStockNo2;
//     BSTR bstrPrice;
//     BSTR bstrPrice2;
//     BSTR bstrTrigger;
//     BSTR bstrTrigger2;
//     BSTR bstrMovingPoint;
//     BSTR bstrDealPrice;
//     short sTradeType;
//     short sBuySell;
//     short sBuySell2;
//     short sDayTrade;
//     short sNewClose; // 0:新倉 1:平倉 2:自動{新期貨、選擇權使用}
//     long nQty;
//     short sReserved;
//     long nTimeFlag;
//     long nOrderPriceType; // 委託價類別  2: 限價; 3:範圍市價 （不支援市價）,sTradeType為ROD時，nOrderPriceType僅可指定限價
//     BSTR bstrCIDTandem;
//     BSTR bstrOrderSign;
//     BSTR bstrSettlementMonth;
//     BSTR bstrStrikePrice;
//     BSTR bstrOrderType;
//     BSTR bstrSeqNo;
//     BSTR bstrBookNo;
//     long nCallPut;
//     long nCurrency;
//     long nTriggerDirection;
//     long nResultFormat;
//     long nFlag;
//     BSTR bstrLongEndDate;
//     long nLongActionFlag;
//     long nLAType;
//     long nMarketNo;
//     BSTR bstrSettlementMonth2;
// };
