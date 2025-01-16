using System.Threading;
using System.Threading.Tasks;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;

namespace Telnyx.NET.PhoneNumber.Interfaces
{
    /// <summary>
    /// Defines operations for managing phone number reservations.
    /// </summary>
    public interface IPhoneNumberReservationsOperations
    {
        /// <summary>
        /// Creates a new phone number reservation.
        /// </summary>
        /// <param name="request">The request object containing the details for the phone number reservation.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the details of the created phone number reservation.</returns>
        Task<CreateNumberReservationResponse> Create(CreateNumberReservationRequest request, CancellationToken cancellationToken = default);
    }
}