using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberReservartions
{
    /// <summary>
    /// Response model for listing number reservations.
    /// Inherits from <see cref="TelnyxResponse{T}"/> with data type <see cref="NumberReservationData"/>.
    /// </summary>
    public class ListNumberReservationsResponse : TelnyxResponse<NumberReservationData>
    {
    }
}