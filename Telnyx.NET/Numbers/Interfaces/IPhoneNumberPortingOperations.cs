using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberPorting;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberPorting;

namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Interface for phone number porting operations.
    /// This includes operations for checking the portability of phone numbers.
    /// </summary>
    public interface IPhoneNumberPortingOperations
    {
        /// <summary>
        /// Initiates a request to check the portability of a phone number.
        /// </summary>
        /// <param name="request">The request containing the phone number details for portability check.</param>
        /// <param name="cancellationToken">The cancellation token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a <see cref="PortabilityCheckResponse"/> result.</returns>
        Task<PortabilityCheckResponse> RunPortabilityCheck(PortabilityCheckRequest request, CancellationToken cancellationToken = default);
    }
}
