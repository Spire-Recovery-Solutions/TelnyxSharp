using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the settings for receiving SIP messages on a subdomain.
    /// Defines the access level for who can send SIP messages to the subdomain.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SipSubdomainReceiveSettings
    {
        /// <summary>
        /// Restricts SIP message reception to only allow connections from authorized peers.
        /// </summary>
        [JsonStringEnumMemberName("only_my_connections")]
        OnlyMyConnections,

        /// <summary>
        /// Allows SIP messages from any sender, regardless of the connection status.
        /// </summary>
        [JsonStringEnumMemberName("from_anyone")]
        FromAnyone
    }
}