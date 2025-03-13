using TelnyxSharp.Numbers.Models.InboundChannels.Requests;
using TelnyxSharp.Numbers.Models.InboundChannels.Responses;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Defines operations for managing inbound channels via the Telnyx API.
    /// These operations allow you to list, update, and manage inbound channels for phone numbers.
    /// </summary>
    public interface IInboundChannelsOperations
    {
        /// <summary>
        /// Lists the inbound channels associated with phone numbers.
        /// Retrieves information about inbound channels configured for your account.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation, with a <see cref="ListInboundChannelsResponse"/> result.</returns>
        Task<ListInboundChannelsResponse> List(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the configuration of inbound channels.
        /// Allows you to modify settings for inbound channels, such as configuring routing or handling.
        /// </summary>
        /// <param name="request">The request object containing the update details.</param>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation, with an <see cref="UpdateInboundChannelsResponse"/> result.</returns>
        Task<UpdateInboundChannelsResponse> Update(UpdateInboundChannelsRequest request,
            CancellationToken cancellationToken = default);
    }
}
