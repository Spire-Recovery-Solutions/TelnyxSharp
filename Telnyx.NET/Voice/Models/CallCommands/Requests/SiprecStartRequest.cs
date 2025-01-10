using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to start SIP recording (Siprec) for a call.
    /// </summary>
    public class SiprecStartRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the name of the connector for the SIP recording.
        /// This specifies the connector to be used for the SIP recording session.
        /// </summary>
        [JsonPropertyName("connector_name")]
        public string? ConnectorName { get; set; }

        /// <summary>
        /// Gets or sets the SIP recording track to be used.
        /// The default value is set to record both tracks (both inbound and outbound).
        /// </summary>
        [JsonPropertyName("siprec_track")]
        public Track SiprecTrack { get; set; } = Track.BothTracks;

        /// <summary>
        /// Gets or sets whether to include metadata custom headers in the SIP recording.
        /// If set to true, custom metadata headers will be included in the recording.
        /// </summary>
        [JsonPropertyName("include_metadata_custom_headers")]
        public bool? IncludeMetadataCustomHeaders { get; set; }

        /// <summary>
        /// Gets or sets whether to use a secure connection for the SIP recording.
        /// If true, a secure connection will be used for the SIP recording.
        /// </summary>
        [JsonPropertyName("secure")]
        public bool? Secure { get; set; }

        /// <summary>
        /// Gets or sets the session timeout in seconds.
        /// The default session timeout is 1800 seconds (30 minutes).
        /// </summary>
        [JsonPropertyName("session_timeout_secs")]
        public int? SessionTimeoutSecs { get; set; } = 1800;

        /// <summary>
        /// Gets or sets the client state associated with the SIP recording start request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }
    }
}