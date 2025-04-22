using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums;

/// <summary>
/// Represents the status of a CDR request.
///
[JsonConverter(typeof(JsonNumberEnumConverter<CdrRequestStatus>))]
public enum CdrRequestStatus
{
    /// <summary>
    /// The request is pending.
    /// </summary>
    Pending = 1,

    /// <summary>
    /// The request is complete.
    /// </summary>
    Complete = 2,

    /// <summary>
    /// The request has failed.
    /// </summary>
    Failed = 3,

    /// <summary>
    /// The request has expired.
    /// </summary>
    Expired = 4
}