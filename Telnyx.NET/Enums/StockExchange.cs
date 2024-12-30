using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StockExchange
    {
        [JsonPropertyName("NONE")]
        None,

        [JsonPropertyName("NASDAQ")]
        NASDAQ,

        [JsonPropertyName("NYSE")]
        NYSE,

        [JsonPropertyName("AMEX")]
        AMEX,

        [JsonPropertyName("AMX")]
        AMX,

        [JsonPropertyName("ASX")]
        ASX,

        [JsonPropertyName("B3")]
        B3,

        [JsonPropertyName("BME")]
        BME,

        [JsonPropertyName("BSE")]
        BSE,

        [JsonPropertyName("FRA")]
        FRA,

        [JsonPropertyName("ICEX")]
        ICEX,

        [JsonPropertyName("JPX")]
        JPX,

        [JsonPropertyName("JSE")]
        JSE,

        [JsonPropertyName("KRX")]
        KRX,

        [JsonPropertyName("LON")]
        LON,

        [JsonPropertyName("NSE")]
        NSE,

        [JsonPropertyName("OMX")]
        OMX,

        [JsonPropertyName("SEHK")]
        SEHK,

        [JsonPropertyName("SSE")]
        SSE,

        [JsonPropertyName("STO")]
        STO,

        [JsonPropertyName("SWX")]
        SWX,

        [JsonPropertyName("SZSE")]
        SZSE,

        [JsonPropertyName("TSX")]
        TSX,

        [JsonPropertyName("TWSE")]
        TWSE,

        [JsonPropertyName("VSE")]
        VSE
    }
}