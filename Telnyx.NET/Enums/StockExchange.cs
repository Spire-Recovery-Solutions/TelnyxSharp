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
        NONE,

        /// <summary>
        /// Represents the NASDAQ stock exchange.
        /// </summary>
        NASDAQ,

        /// <summary>
        /// Represents the New York Stock Exchange.
        /// </summary>
        NYSE,

        /// <summary>
        /// Represents the American Stock Exchange.
        /// </summary>
        AMEX,

        /// <summary>
        /// Represents the AMX stock exchange.
        /// </summary>
        AMX,

        /// <summary>
        /// Represents the Australian Securities Exchange.
        /// </summary>
        ASX,

        /// <summary>
        /// Represents the B3 (Brazil) stock exchange.
        /// </summary>
        B3,

        /// <summary>
        /// Represents the Bolsa de Madrid (Spain) stock exchange.
        /// </summary>
        BME,

        /// <summary>
        /// Represents the Bombay Stock Exchange (India).
        /// </summary>
        BSE,

        /// <summary>
        /// Represents the Frankfurt Stock Exchange (Germany).
        /// </summary>
        FRA,

        /// <summary>
        /// Represents the Iceland Stock Exchange.
        /// </summary>
        ICEX,

        /// <summary>
        /// Represents the Japan Exchange Group.
        /// </summary>
        JPX,

        /// <summary>
        /// Represents the Johannesburg Stock Exchange.
        /// </summary>
        JSE,

        /// <summary>
        /// Represents the Korea Stock Exchange.
        /// </summary>
        KRX,

        /// <summary>
        /// Represents the London Stock Exchange.
        /// </summary>
        LON,

        /// <summary>
        /// Represents the National Stock Exchange of India.
        /// </summary>
        NSE,

        /// <summary>
        /// Represents the OMX stock exchange (Nordic countries).
        /// </summary>
        OMX,

        /// <summary>
        /// Represents the Hong Kong Stock Exchange.
        /// </summary>
        SEHK,

        /// <summary>
        /// Represents the Shanghai Stock Exchange.
        /// </summary>
        SSE,

        /// <summary>
        /// Represents the Stockholm Stock Exchange.
        /// </summary>
        STO,

        /// <summary>
        /// Represents the Swiss Exchange.
        /// </summary>
        SWX,

        /// <summary>
        /// Represents the Shenzhen Stock Exchange.
        /// </summary>
        SZSE,

        /// <summary>
        /// Represents the Toronto Stock Exchange.
        /// </summary>
        TSX,

        /// <summary>
        /// Represents the Taiwan Stock Exchange.
        /// </summary>
        TWSE,

        /// <summary>
        /// Represents the Ho Chi Minh Stock Exchange (Vietnam).
        /// </summary>
        VSE
    }
}