using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder;

namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Defines operations for managing and retrieving porting orders and porting phone numbers.
    /// </summary>
    public interface IPortingOrderOperations
    {
        /// <summary>
        /// Retrieves a list of porting orders based on the specified filters.
        /// </summary>
        /// <param name="request">The request object containing filters and pagination options for porting orders.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the response with a list of porting orders matching the specified criteria.
        /// </returns>
        Task<ListPortingOrdersResponse> List(ListPortingOrdersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of phone numbers associated with porting orders, based on the specified filters.
        /// </summary>
        /// <param name="request">The request object containing filters and pagination options for porting phone numbers.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the response with a list of porting phone numbers matching the specified criteria.
        /// </returns>
        Task<ListPortingPhoneNumbersResponse> ListPhoneNumbers(ListPortingPhoneNumbersRequest request, CancellationToken cancellationToken = default);
    }
}