using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.AdvancedOptInOptOut.Responses
{
    /// <summary>
    /// Represents the response received after attempting to delete an auto-response setting.
    /// Implements the ITelnyxResponse interface to maintain consistency with Telnyx's API response structure.
    /// </summary>
    public class DeleteAutoResponseSettingResponse : TelnyxResponse
    {
    }
}