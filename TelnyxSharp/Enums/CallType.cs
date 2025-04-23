using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing call types for CDR reports.
    /// </summary>
    [JsonConverter(typeof(JsonNumberEnumConverter<CallType>))]
    public enum CallType
    {
        /// <summary>
        /// Inbound calls (value: 1).
        /// </summary>
        Inbound = 1,
        
        /// <summary>
        /// Outbound calls (value: 2).
        /// </summary>
        Outbound = 2
    }
}
