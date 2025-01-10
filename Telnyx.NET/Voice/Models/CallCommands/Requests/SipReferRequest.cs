using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to perform a SIP REFER operation, which initiates a transfer or redirect of a call.
    /// </summary>
    public class SipReferRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the SIP address to which the call should be redirected or transferred.
        /// This is a required field for the SIP REFER request.
        /// </summary>
        [JsonPropertyName("sip_address")]
        public required string SipAddress { get; set; }

        /// <summary>
        /// Gets or sets the client state associated with the SIP REFER request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the SIP REFER request.
        /// This ID can be used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets a list of custom headers that can be included in the SIP REFER request.
        /// These headers can be used to provide additional information or modify the behavior of the request.
        /// </summary>
        [JsonPropertyName("custom_headers")]
        public List<CustomHeader>? CustomHeaders { get; set; }

        /// <summary>
        /// Gets or sets the SIP authentication username for the SIP REFER request.
        /// This can be used if authentication is required for the SIP REFER request.
        /// </summary>
        [JsonPropertyName("sip_auth_username")]
        public string? SipAuthUsername { get; set; }

        /// <summary>
        /// Gets or sets the SIP authentication password for the SIP REFER request.
        /// This is used in conjunction with the SIP authentication username.
        /// </summary>
        [JsonPropertyName("sip_auth_password")]
        public string? SipAuthPassword { get; set; }

        /// <summary>
        /// Gets or sets a list of SIP headers to be included in the SIP REFER request.
        /// These headers can be used to modify the behavior or include additional information in the request.
        /// </summary>
        [JsonPropertyName("sip_headers")]
        public List<SipHeader>? SipHeaders { get; set; }
    }
}