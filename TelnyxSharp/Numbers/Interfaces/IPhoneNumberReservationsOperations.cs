using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberReservations;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberReservartions;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Defines operations for managing phone number reservations.
    /// </summary>
    public interface IPhoneNumberReservationsOperations
    {
        /// <summary>
        /// Retrieves a list of phone number reservations with the specified filtering and pagination options.
        /// </summary>
        /// <param name="request">The request object containing the filter criteria and pagination settings for retrieving phone number reservations.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the list of phone number reservations.</returns>
        Task<ListNumberReservationsResponse> List(ListNumberReservationsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new phone number reservation.
        /// </summary>
        /// <param name="request">The request object containing the details for the phone number reservation.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the details of the created phone number reservation.</returns>
        Task<CreateNumberReservationResponse> Create(CreateNumberReservationRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the details of a specific phone number reservation by its ID.
        /// </summary>
        /// <param name="numberReservationId">The unique identifier of the phone number reservation to retrieve.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the details of the specified phone number reservation.</returns>
        Task<GetNumberReservationResponse> Get(string numberReservationId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Extends an existing phone number reservation to keep it active for a longer duration.
        /// </summary>
        /// <param name="numberReservationId">The unique identifier of the phone number reservation to extend.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the details of the extended phone number reservation.</returns>
        Task<ExtendNumberReservationResponse> Extend(string numberReservationId, CancellationToken cancellationToken = default);
    }
}