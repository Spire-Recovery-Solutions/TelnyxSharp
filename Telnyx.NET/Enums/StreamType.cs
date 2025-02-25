﻿using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the types of streams.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StreamType
    {
        /// <summary>
        /// A raw, unprocessed stream, typically in its original form.
        /// </summary>
        Raw,

        /// <summary>
        /// A decrypted stream, typically after being processed to remove encryption.
        /// </summary>
        Decrypted
    }
}