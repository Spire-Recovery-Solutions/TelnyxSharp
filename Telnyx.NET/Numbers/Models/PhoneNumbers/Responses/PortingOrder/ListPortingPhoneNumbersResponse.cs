using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Response object for retrieving a list of porting phone numbers.
    /// </summary>
    public class ListPortingPhoneNumbersResponse : TelnyxResponse<List<PortingOrdersPhoneNumber>>
    {
    }
}