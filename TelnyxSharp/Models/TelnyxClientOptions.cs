namespace TelnyxSharp.Models
{
    /// <summary>
    /// Represents the configuration options for the Telnyx client.
    /// </summary>
    public class TelnyxClientOptions
    {
        /// <summary>
        /// Gets or sets the API key used for authentication with the Telnyx API.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the base URL for the Telnyx API.
        /// Defaults to "https://api.telnyx.com/v2/".
        /// </summary>
        public string BaseUrl { get; set; } = "https://api.telnyx.com/v2/";

        /// <summary>
        /// Gets or sets the timeout duration for API requests.
        /// Defaults to 30 seconds.
        /// </summary>
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);

        /// <summary>
        /// Gets or sets whether to enable automatic retries for failed requests.
        /// Defaults to true.
        /// </summary>
        public bool UseRetry { get; set; } = true;

        /// <summary>
        /// Gets or sets the maximum number of retry attempts for failed requests.
        /// Defaults to 3 retry attempts.
        /// </summary>
        public int MaxRetryAttempts { get; set; } = 3;

        /// <summary>
        /// Gets or sets the rate limit configuration for the Telnyx API.
        /// </summary>
        public TelnyxRateLimitConfiguration RateLimits { get; set; }
    }
}