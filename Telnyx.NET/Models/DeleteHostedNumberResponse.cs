using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response after deleting a messaging hosted number.
    /// </summary>
    public class DeleteHostedNumberResponse : TelnyxResponse<DeleteHostedNumberData>
    {
    }

    public class DeleteHostedNumberData : BaseHostedNumberOrderData
    {
    }
}
