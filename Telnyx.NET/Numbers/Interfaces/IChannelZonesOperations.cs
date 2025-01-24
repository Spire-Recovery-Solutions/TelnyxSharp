using Telnyx.NET.Numbers.Models.ChannelZones.Requests;
using Telnyx.NET.Numbers.Models.ChannelZones.Responses;

namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Defines operations for managing channel zones and their associated phone numbers.
    /// </summary>
    public interface IChannelZonesOperations
    {
        /// <summary>
        /// Retrieves a list of channel zones with pagination support.
        /// </summary>
        /// <param name="request">The request containing pagination parameters.</param>
        /// <param name="cancellationToken">Optional cancellation token for the request.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of channel zones.</returns>
        Task<ListChannelZonesResponse> List(ListChannelZonesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific channel zone by its ID.
        /// </summary>
        /// <param name="channelZoneId">The ID of the channel zone to retrieve.</param>
        /// <param name="cancellationToken">Optional cancellation token for the request.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the channel zone details.</returns>
        Task<GetChannelZonesResponse> Get(string channelZoneId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a specific channel zone by its ID.
        /// </summary>
        /// <param name="channelZoneId">The ID of the channel zone to update.</param>
        /// <param name="request">The request containing update details.</param>
        /// <param name="cancellationToken">Optional cancellation token for the request.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the updated channel zone details.</returns>
        Task<UpdateChannelZoneResponse> Update(string channelZoneId, UpdateChannelZoneRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the list of phone numbers assigned to a specific channel zone.
        /// </summary>
        /// <param name="channelZoneId">The ID of the channel zone.</param>
        /// <param name="request">The request containing pagination parameters.</param>
        /// <param name="cancellationToken">Optional cancellation token for the request.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of phone numbers.</returns>
        Task<GetChannelZonePhoneNumbersResponse> ListPhoneNumbers(string channelZoneId, GetChannelZonePhoneNumbersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Assigns a phone number to a specific channel zone.
        /// </summary>
        /// <param name="channelZoneId">The ID of the channel zone.</param>
        /// <param name="request">The request containing the phone number assignment details.</param>
        /// <param name="cancellationToken">Optional cancellation token for the request.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the assignment response details.</returns>
        Task<AssignPhoneNumberToChannelZoneResponse> AssignPhoneNumber(string channelZoneId, AssignPhoneNumberToChannelZoneRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Unassigns a phone number from a specific channel zone.
        /// </summary>
        /// <param name="channelZoneId">The ID of the channel zone.</param>
        /// <param name="phoneNumber">The phone number to unassign.</param>
        /// <param name="cancellationToken">Optional cancellation token for the request.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the unassignment response details.</returns>
        Task<UnassignPhoneNumberResponse> UnassignPhoneNumber(string channelZoneId, string phoneNumber, CancellationToken cancellationToken = default);
    }
}

