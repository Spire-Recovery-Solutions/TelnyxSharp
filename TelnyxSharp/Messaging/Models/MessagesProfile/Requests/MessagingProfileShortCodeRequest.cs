using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.MessagesProfile.Requests
{
    /// <summary>
    /// Represents the request parameters for listing short codes associated with a messaging profile.
    /// </summary>
    public class MessagingProfileShortCodeRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the page number to load.
        /// Default value is 1.
        /// </summary>
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// Gets or sets the size of the page (number of items per page).
        /// Default value is 20.
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
}
