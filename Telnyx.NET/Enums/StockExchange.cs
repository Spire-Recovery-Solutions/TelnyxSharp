using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing various stock exchanges.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StockExchange
    {
        /// <summary>
        /// Represents no stock exchange.
        /// </summary>
        [JsonPropertyName("NONE")]
        None,

        /// <summary>
        /// Represents the NASDAQ stock exchange.
        /// </summary>
        [JsonPropertyName("NASDAQ")]
        NASDAQ,

        /// <summary>
        /// Represents the New York Stock Exchange.
        /// </summary>
        [JsonPropertyName("NYSE")]
        NYSE,

        /// <summary>
        /// Represents the American Stock Exchange.
        /// </summary>
        [JsonPropertyName("AMEX")]
        AMEX,

        /// <summary>
        /// Represents the AMX stock exchange.
        /// </summary>
        [JsonPropertyName("AMX")]
        AMX,

        /// <summary>
        /// Represents the Australian Securities Exchange.
        /// </summary>
        [JsonPropertyName("ASX")]
        ASX,

        /// <summary>
        /// Represents the B3 (Brazil) stock exchange.
        /// </summary>
        [JsonPropertyName("B3")]
        B3,

        /// <summary>
        /// Represents the Bolsa de Madrid (Spain) stock exchange.
        /// </summary>
        [JsonPropertyName("BME")]
        BME,

        /// <summary>
        /// Represents the Bombay Stock Exchange (India).
        /// </summary>
        [JsonPropertyName("BSE")]
        BSE,

        /// <summary>
        /// Represents the Frankfurt Stock Exchange (Germany).
        /// </summary>
        [JsonPropertyName("FRA")]
        FRA,

        /// <summary>
        /// Represents the Iceland Stock Exchange.
        /// </summary>
        [JsonPropertyName("ICEX")]
        ICEX,

        /// <summary>
        /// Represents the Japan Exchange Group.
        /// </summary>
        [JsonPropertyName("JPX")]
        JPX,

        /// <summary>
        /// Represents the Johannesburg Stock Exchange.
        /// </summary>
        [JsonPropertyName("JSE")]
        JSE,

        /// <summary>
        /// Represents the Korea Stock Exchange.
        /// </summary>
        [JsonPropertyName("KRX")]
        KRX,

        /// <summary>
        /// Represents the London Stock Exchange.
        /// </summary>
        [JsonPropertyName("LON")]
        LON,

        /// <summary>
        /// Represents the National Stock Exchange of India.
        /// </summary>
        [JsonPropertyName("NSE")]
        NSE,

        /// <summary>
        /// Represents the OMX stock exchange (Nordic countries).
        /// </summary>
        [JsonPropertyName("OMX")]
        OMX,

        /// <summary>
        /// Represents the Hong Kong Stock Exchange.
        /// </summary>
        [JsonPropertyName("SEHK")]
        SEHK,

        /// <summary>
        /// Represents the Shanghai Stock Exchange.
        /// </summary>
        [JsonPropertyName("SSE")]
        SSE,

        /// <summary>
        /// Represents the Stockholm Stock Exchange.
        /// </summary>
        [JsonPropertyName("STO")]
        STO,

        /// <summary>
        /// Represents the Swiss Exchange.
        /// </summary>
        [JsonPropertyName("SWX")]
        SWX,

        /// <summary>
        /// Represents the Shenzhen Stock Exchange.
        /// </summary>
        [JsonPropertyName("SZSE")]
        SZSE,

        /// <summary>
        /// Represents the Toronto Stock Exchange.
        /// </summary>
        [JsonPropertyName("TSX")]
        TSX,

        /// <summary>
        /// Represents the Taiwan Stock Exchange.
        /// </summary>
        [JsonPropertyName("TWSE")]
        TWSE,

        /// <summary>
        /// Represents the Ho Chi Minh Stock Exchange (Vietnam).
        /// </summary>
        [JsonPropertyName("VSE")]
        VSE
    }
}