using Telnyx.NET.Messaging.Models.NumberConfigurations;

namespace Telnyx.NET.Messaging.Interfaces
{
    public interface INumberConfigurationOperations
    {
        /// <summary>
        /// Lists phone message settings with pagination support.
        /// </summary>
        /// <param name="request">Request parameters for listing phone message settings.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<ListPhoneMessageSettingsResponse?> List(
            ListPhoneMessageSettingsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves phone message settings for a specific number.
        /// </summary>
        /// <param name="id">The ID of the phone number.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<RetrievePhoneMessageSettingsResponse?> Retrieve(
            string id,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the phone message settings for a specific number.
        /// </summary>
        /// <param name="id">The ID of the phone number.</param>
        /// <param name="request">The request containing the updated settings.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<UpdatePhoneNumberMessagingResponse?> Update(
            string id,
            UpdatePhoneNumberMessagingRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates messaging settings for multiple phone numbers in bulk.
        /// </summary>
        /// <param name="request">The request containing bulk update details.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<UpdateNumbersMessagingBulkResponse?> UpdateMultipleNumbers(
            UpdateNumbersMessagingBulkRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the status of a bulk update operation.
        /// </summary>
        /// <param name="orderId">The ID of the bulk update operation.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<RetrieveBulkUpdateStatusResponse?> RetrieveBulkUpdateStatusAsync(
            string orderId,
            CancellationToken cancellationToken = default);
    }
}
