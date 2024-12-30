using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StockExchange
    {
        NONE,
        NASDAQ,
        NYSE,
        AMEX,
        AMX,
        ASX,
        B3,
        BME,
        BSE,
        FRA,
        ICEX,
        JPX,
        JSE,
        KRX,
        LON,
        NSE,
        OMX,
        SEHK,
        SSE,
        STO,
        SWX,
        SZSE,
        TSX,
        TWSE,
        VSE
    }

}
