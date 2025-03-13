namespace TelnyxSharp.Models
{
    /// <summary>
    /// Represents the rate limit configuration for the Telnyx API.
    /// </summary>
    public sealed class TelnyxRateLimitConfiguration
    {
        /// <summary>
        /// Gets or sets the global rate limit for all API requests.
        /// Defaults to 40 requests per minute.
        /// </summary>
        public int Global { get; set; } = 40;

        /// <summary>
        /// Gets or sets the rate limit for number search requests.
        /// Defaults to 40 requests per minute.
        /// </summary>
        public int NumberSearch { get; set; } = 40;

        /// <summary>
        /// Gets or sets the rate limit for phone number requests.
        /// Defaults to 60 requests per minute.
        /// </summary>
        public int PhoneNumbers { get; set; } = 60;

        /// <summary>
        /// Gets or sets the rate limit for connection-related requests.
        /// Defaults to 5 requests per minute.
        /// </summary>
        public int Connections { get; set; } = 5;

        /// <summary>
        /// Gets or sets the rate limit for Fully Qualified Domain Name (FQDN) connection-related requests.
        /// Defaults to 5 requests per minute.
        /// </summary>
        public int FQDNConnections { get; set; } = 5;

        /// <summary>
        /// Gets or sets the rate limit for IP connection-related requests.
        /// Defaults to 5 requests per minute.
        /// </summary>
        public int IPConnections { get; set; } = 5;

        /// <summary>
        /// Gets or sets the rate limit for credential connection-related requests.
        /// Defaults to 5 requests per minute.
        /// </summary>
        public int CredentialsConnections { get; set; } = 5;

        /// <summary>
        /// Gets or sets the rate limit for call control application-related requests.
        /// Defaults to 5 requests per minute.
        /// </summary>
        public int CallControlApplications { get; set; } = 5;

        /// <summary>
        /// Gets or sets the rate limit for TeXML application-related requests.
        /// Defaults to 5 requests per minute.
        /// </summary>
        public int TeXMLApplications { get; set; } = 5;

        /// <summary>
        /// Gets or sets the rate limit for fax application-related requests.
        /// Defaults to 5 requests per minute.
        /// </summary>
        public int FaxApplications { get; set; } = 5;

        /// <summary>
        /// Gets or sets the rate limit for outbound voice profile-related requests.
        /// Defaults to 5 requests per minute.
        /// </summary>
        public int OutboundVoiceProfiles { get; set; } = 5;

        /// <summary>
        /// Gets or sets the rate limit for messaging profile-related requests.
        /// Defaults to 5 requests per minute.
        /// </summary>
        public int MessagingProfiles { get; set; } = 5;

        /// <summary>
        /// Gets or sets the rate limit for number order requests.
        /// Defaults to 1 request per minute.
        /// </summary>
        public int NumberOrders { get; set; } = 1;

        /// <summary>
        /// Gets or sets the rate limit for sending messages.
        /// Defaults to 1 request per minute.
        /// </summary>
        public int SendMessage { get; set; } = 1;

        /// <summary>
        /// Gets or sets the rate limit for porting number requests.
        /// Defaults to 1 request per minute.
        /// </summary>
        public int PortNumbers { get; set; } = 1;

        /// <summary>
        /// Gets or sets the rate limit for number reservation requests.
        /// Defaults to 1 request per minute.
        /// </summary>
        public int NumberReservations { get; set; } = 1;

        /// <summary>
        /// Gets or sets the rate limit for number lookup requests.
        /// Defaults to 1 request per minute.
        /// </summary>
        public int NumberLookups { get; set; } = 1;

        /// <summary>
        /// Gets or sets the rate limit for call requests.
        /// Defaults to 100 requests per minute.
        /// </summary>
        public int Calls { get; set; } = 100;
    }
}