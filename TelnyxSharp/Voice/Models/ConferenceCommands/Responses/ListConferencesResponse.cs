using TelnyxSharp.Models;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Responses
{
    /// <summary>
    /// Represents the response for listing all conferences.
    /// This contains a list of conference data.
    /// </summary>
    public class ListConferencesResponse : TelnyxResponse<List<ListConferenceData>>
    {
    }

    /// <summary>
    /// Represents the data for each conference in the list of conferences.
    /// It inherits from the base conference data class.
    /// </summary>
    public class ListConferenceData : BaseConferenceData
    {
    }
}