using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for listing participants in a conference.
    /// This model allows filtering the participants by their status (muted, on hold, whispering),
    /// and it supports pagination to manage the number of participants returned.
    /// </summary>
    public class ListConferenceParticipantsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier for the conference.
        /// This ID is used to specify which conference's participants should be listed.
        /// </summary>
        public string? ConferenceId { get; set; }

        /// <summary>
        /// Gets or sets the filter for muted participants.
        /// If set to true, only participants who are muted will be returned.
        /// </summary>
        public bool? Muted { get; set; }

        /// <summary>
        /// Gets or sets the filter for participants who are on hold.
        /// If set to true, only participants who are on hold will be returned.
        /// </summary>
        public bool? OnHold { get; set; }

        /// <summary>
        /// Gets or sets the filter for participants who are whispering.
        /// If set to true, only participants who are whispering will be returned.
        /// </summary>
        public bool? Whispering { get; set; }

        /// <summary>
        /// Gets or sets the number of participants to be returned per page.
        /// The default page size is 20.
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
}