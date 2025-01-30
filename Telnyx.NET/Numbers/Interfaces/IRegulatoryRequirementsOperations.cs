using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.RegulatoryRequirements;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RegulatoryRequirements;

namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Defines operations for managing regulatory requirements related to phone numbers.
    /// This includes retrieving and checking regulatory requirements for specific phone numbers, 
    /// including information based on phone number, country, and the type of action required.
    /// </summary>
    public interface IRegulatoryRequirementsOperations
    {
        /// <summary>
        /// Retrieves regulatory requirements based on the provided filters.
        /// </summary>
        /// <param name="request">Request object containing filter parameters like phone number, requirement group ID, country code, phone number type, and action.</param>
        /// <param name="cancellationToken">Optional cancellation token to cancel the request.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response with regulatory requirements.</returns>
        Task<GetRegulatoryRequirementsResponse> Get(GetRegulatoryRequirementsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves regulatory requirements for a specific phone number.
        /// </summary>
        /// <param name="request">Request object containing the phone number to check regulatory requirements for.</param>
        /// <param name="cancellationToken">Optional cancellation token to cancel the request.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response with a list of regulatory requirements.</returns>
        Task<ListRegulatoryRequirementsResponse> GetPhoneNumber(ListRegulatoryRequirementsRequest request, CancellationToken cancellationToken = default);
    }
}
