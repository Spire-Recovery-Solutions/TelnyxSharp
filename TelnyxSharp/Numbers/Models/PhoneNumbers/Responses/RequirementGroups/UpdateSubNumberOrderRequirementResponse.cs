using System.Text.Json.Serialization;
using TelnyxSharp.Models;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.RequirementGroups
{
    /// <summary>
    /// Represents the response for updating a sub-number order requirement.
    /// It extends the `TelnyxResponse<SubNumberOrderData>` class, containing details about the sub-number order.
    /// </summary>
    public class UpdateSubNumberOrderRequirementResponse : TelnyxResponse<SubNumberOrderData>
    {
    }

    public class UpdateSubNumberOrderRequirementData : SubNumberOrderData
    {
        /// <summary>
        /// A list of phone numbers associated with the sub-number order.
        /// This property is serialized with the name "phone_numbers".
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<PhoneNumberOrderData>? PhoneNumbers { get; set; }
    }
}