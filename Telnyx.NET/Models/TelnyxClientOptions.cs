namespace Telnyx.NET.Models
{
    public class TelnyxClientOptions
    {
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; } = "https://api.telnyx.com/v2/";
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);
        public bool UseRetry { get; set; } = true;
        public int MaxRetryAttempts { get; set; } = 3;
        public TelnyxRateLimitConfiguration RateLimits { get; set; }
    }
}
