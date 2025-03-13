using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.MessagesProfile.Requests
{
    public class MessagingProfileMetricsRequest : ITelnyxRequest
    {

        /// <summary>
        /// The size of the page. Default is 20.
        /// </summary>
        public int PageSize { get; set; } = 20;

        /// <summary>
        /// The ID of the messaging profile(s) to retrieve.
        /// </summary>
        public string MessagingProfileId { get; set; } = string.Empty;

        /// <summary>
        /// The timeframe for which you'd like to retrieve metrics.
        /// Possible values: [1h, 3h, 24h, 3d, 7d, 30d]. Default is 24h.
        /// </summary>
        public string TimeFrame { get; set; } = "24h";
    }
}
