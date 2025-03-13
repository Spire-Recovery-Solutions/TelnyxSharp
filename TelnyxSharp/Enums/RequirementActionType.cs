using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the possible actions to check requirements for.
    /// This enum is used to specify the type of action when checking phone number requirements.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RequirementActionType
    {
        /// <summary>
        /// Action type for ordering a phone number.
        /// This action is used when checking the requirements for ordering a new phone number.
        /// </summary>
        Ordering,

        /// <summary>
        /// Action type for porting a phone number.
        /// This action is used when checking the requirements for porting an existing phone number to a different carrier.
        /// </summary>
        Porting,

        /// <summary>
        /// Action type for a general action.
        /// This action is used for general checks, which might involve additional operations on phone numbers.
        /// </summary>
        Action
    }
}