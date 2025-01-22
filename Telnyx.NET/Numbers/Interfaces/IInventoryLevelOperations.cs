using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.InventoryLevel;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.InventoryLevel;

namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Operations for phone number inventory coverage.
    /// </summary>
    public interface IInventoryLevelOperations
    {
        /// <summary>
        /// Gets inventory coverage based on the specified filters.
        /// </summary>
        /// <param name="request">The filters for the inventory coverage.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        /// <returns>The inventory coverage details.</returns>
        Task<InventoryCoverageResponse> Get(InventoryCoverageRequest request, CancellationToken cancellationToken = default);
    }
}
