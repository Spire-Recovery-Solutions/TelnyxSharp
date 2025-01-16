using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Messaging.Models.MessagesProfile.Requests
{
    /// <summary>
    /// Represents the request parameters for retrieving messaging profile metrics.
    /// </summary>
    public class RetrieveMessagingProfileMetricsRequest : ITelnyxRequest
    {

        /// <summary>
        /// Gets or sets the timeframe for which you'd like to retrieve metrics.
        /// Possible values: [1h, 3h, 24h, 3d, 7d, 30d]. Default is "24h".
        /// </summary>
        public TimeFrame? TimeFrame { get; set; } = NET.Enums.TimeFrame.TwentyFourHours;
    }
}
