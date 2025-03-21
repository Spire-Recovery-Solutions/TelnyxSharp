﻿using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response from the Telnyx API for the Answer Call command.
    /// </summary>
    public class CallCommandsResponse : TelnyxResponse<CallCommandsResponseData>
    {

    }

    /// <summary>
    /// Represents the data object in the Answer Call response.
    /// </summary>
    public class CallCommandsResponseData
    {
        /// <summary>
        /// The result of the Answer Call command.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = "Unexpected error";
    }
}
