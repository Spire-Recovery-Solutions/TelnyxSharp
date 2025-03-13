using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for retrieving a list of porting exception types.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> where T is a list of <see cref="ExceptionType"/>.
    /// </summary>
    public class ListPortingExceptionTypesResponse : TelnyxResponse<List<ExceptionType>>
    {
    }

    /// <summary>
    /// Represents a single exception type related to porting.
    /// </summary>
    public class ExceptionType
    {
        /// <summary>
        /// Gets or sets the unique code for the exception type.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the description of the exception type.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}