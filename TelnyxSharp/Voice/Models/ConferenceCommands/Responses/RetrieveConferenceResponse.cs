using TelnyxSharp.Models;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Responses
{
    /// <summary>
    /// Represents the response for retrieving a specific conference.
    /// It contains the conference data.
    /// </summary>
    public class RetrieveConferenceResponse : TelnyxResponse<RetrieveConferenceData>
    {
    }

    /// <summary>
    /// Represents the data for a specific retrieved conference.
    /// It inherits from the base conference data class.
    /// </summary>
    public class RetrieveConferenceData : BaseConferenceData
    {
    }
}