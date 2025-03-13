using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.NumbersFeatures;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.NumbersFeatures;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Provides operations for interacting with the Numbers Features API, 
    /// allowing you to retrieve features associated with phone numbers.
    /// </summary>
    public interface INumbersFeaturesOperations
    {
        /// <summary>
        /// Retrieves the features associated with the specified phone numbers.
        /// </summary>
        /// <param name="request">The request containing the phone numbers and other parameters to retrieve features for.</param>
        /// <param name="cancellationToken">A cancellation token for controlling the request's lifetime.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the numbers' features.</returns>
        Task<GetNumbersFeaturesResponse> Get(GetNumbersFeaturesRequest request, CancellationToken cancellationToken = default);
    }
}
