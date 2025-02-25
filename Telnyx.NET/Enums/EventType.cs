using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the types of events that can occur in the Telnyx system.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EventType
    {
        /// <summary>
        /// Indicates a command event type.
        /// </summary>
        command,

        /// <summary>
        /// Indicates a webhook event type.
        /// </summary>
        webhook
    }
}