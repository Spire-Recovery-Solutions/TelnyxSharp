﻿using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberReservartions
{
    /// <summary>
    /// Response model for listing number reservations.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> with data type <see cref="NumberReservationData"/>.
    /// </summary>
    public class ListNumberReservationsResponse : TelnyxResponse<NumberReservationData>
    {
    }
}