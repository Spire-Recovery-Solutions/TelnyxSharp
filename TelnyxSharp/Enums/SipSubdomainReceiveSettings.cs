using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the settings for receiving SIP messages on a subdomain.
    /// Defines the access level for who can send SIP messages to the subdomain.
    /// </summary>
    [JsonConverter(typeof(SipSubdomainReceiveSettingsConverter))]
    public enum SipSubdomainReceiveSettings
    {
        /// <summary>
        /// Restricts SIP message reception to only allow connections from authorized peers.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("only_my_connections")]
        OnlyMyConnections,

        /// <summary>
        /// Allows SIP messages from any sender, regardless of the connection status.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("from_anyone")]
        FromAnyone
    }
}