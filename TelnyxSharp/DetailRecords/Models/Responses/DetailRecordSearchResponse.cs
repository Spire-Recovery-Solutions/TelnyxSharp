using System.Text.Json.Serialization;
using TelnyxSharp.Converters;
using TelnyxSharp.Models;

namespace TelnyxSharp.DetailRecords.Models.Responses
{
    /// <summary>
    /// Represents the response from the detail records search endpoint.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> with a list of polymorphic detail records.
    /// </summary>
    public class DetailRecordSearchResponse : TelnyxResponse<List<DetailRecordBase>>
    {
        /// <summary>
        /// Gets or sets the list of detail records.
        /// A custom JSON converter is used to handle polymorphic deserialization.
        /// </summary>
        [JsonConverter(typeof(DetailRecordListConverter))]
        public new List<DetailRecordBase>? Data { get; set; }
    }

    /// <summary>
    /// Abstract base class for all detail records.
    /// </summary>
    public abstract class DetailRecordBase
    {
        /// <summary>
        /// Gets or sets the record type. This property is used to determine the concrete type during deserialization.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; }
    }

    /// <summary>
    /// Represents a message detail record.
    /// Contains information about a messaging transaction.
    /// </summary>
    public class MessageDetailRecord : DetailRecordBase
    {
        /// <summary>
        /// Gets or sets the unique identifier of the message.
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx account identifier associated with the message.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the message completion time.
        /// </summary>
        [JsonPropertyName("completed_at")]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets the message creation time.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the time when the message was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the time when the message was sent.
        /// </summary>
        [JsonPropertyName("sent_at")]
        public DateTime? SentAt { get; set; }

        /// <summary>
        /// Gets or sets the carrier used for the message.
        /// </summary>
        [JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or sets the carrier fee charged.
        /// </summary>
        [JsonPropertyName("carrier_fee")]
        public string CarrierFee { get; set; }

        /// <summary>
        /// Gets or sets the recipient (CLD) of the message.
        /// </summary>
        [JsonPropertyName("cld")]
        public string Cld { get; set; }

        /// <summary>
        /// Gets or sets the sender (CLI) of the message.
        /// </summary>
        [JsonPropertyName("cli")]
        public string Cli { get; set; }

        /// <summary>
        /// Gets or sets the country code associated with the message.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the delivery status of the message.
        /// </summary>
        [JsonPropertyName("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// Gets or sets the failover URL for delivery status.
        /// </summary>
        [JsonPropertyName("delivery_status_failover_url")]
        public string DeliveryStatusFailoverUrl { get; set; }

        /// <summary>
        /// Gets or sets the primary webhook URL for delivery status.
        /// </summary>
        [JsonPropertyName("delivery_status_webhook_url")]
        public string DeliveryStatusWebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the logical direction of the message (inbound/outbound).
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is an FTEU message.
        /// </summary>
        [JsonPropertyName("fteu")]
        public bool Fteu { get; set; }

        /// <summary>
        /// Gets or sets the Mobile Country Code (MCC).
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// Gets or sets the Mobile Network Code (MNC).
        /// </summary>
        [JsonPropertyName("mnc")]
        public string Mnc { get; set; }

        /// <summary>
        /// Gets or sets the messaging type (SMS, MMS, RCS).
        /// </summary>
        [JsonPropertyName("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether both sender and recipient numbers are Telnyx-managed.
        /// </summary>
        [JsonPropertyName("on_net")]
        public bool OnNet { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the messaging profile.
        /// </summary>
        [JsonPropertyName("profile_id")]
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the name of the messaging profile.
        /// </summary>
        [JsonPropertyName("profile_name")]
        public string ProfileName { get; set; }

        /// <summary>
        /// Gets or sets the source country code for the CLI.
        /// </summary>
        [JsonPropertyName("source_country_code")]
        public string SourceCountryCode { get; set; }

        /// <summary>
        /// Gets or sets the final status of the message.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets a comma-separated list of tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or sets the rate charged per billing unit.
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Gets or sets the currency used for billing.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the cost of the message.
        /// </summary>
        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// Gets or sets the list of error codes returned by the Telnyx gateway.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Gets or sets the number of parts the message is split into.
        /// </summary>
        [JsonPropertyName("parts")]
        public int Parts { get; set; }
    }

    /// <summary>
    /// Represents a conference detail record.
    /// Contains information about a conference call.
    /// </summary>
    public class ConferenceDetailRecord : DetailRecordBase
    {
        /// <summary>
        /// Gets or sets the unique identifier of the conference.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the conference.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx account identifier associated with the conference.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the conference start time.
        /// </summary>
        [JsonPropertyName("started_at")]
        public DateTime StartedAt { get; set; }

        /// <summary>
        /// Gets or sets the conference end time.
        /// </summary>
        [JsonPropertyName("ended_at")]
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Gets or sets the conference expiry time.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets the region where the conference is hosted.
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx UUID for the conference call leg.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string CallLegId { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx UUID for the conference call session.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string CallSessionId { get; set; }

        /// <summary>
        /// Gets or sets the connection identifier.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the duration of the conference call in seconds.
        /// </summary>
        [JsonPropertyName("call_sec")]
        public int CallSec { get; set; }

        /// <summary>
        /// Gets or sets the number of participants that joined the conference call.
        /// </summary>
        [JsonPropertyName("participant_count")]
        public int ParticipantCount { get; set; }

        /// <summary>
        /// Gets or sets the sum of all participants' call durations in seconds.
        /// </summary>
        [JsonPropertyName("participant_call_sec")]
        public int ParticipantCallSec { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Telnyx billing applies.
        /// </summary>
        [JsonPropertyName("is_telnyx_billable")]
        public bool IsTelnyxBillable { get; set; }
    }

    /// <summary>
    /// Represents a conference participant detail record.
    /// Contains information about a participant's involvement in a conference call.
    /// </summary>
    public class ConferenceParticipantDetailRecord : DetailRecordBase
    {
        /// <summary>
        /// Gets or sets the unique identifier of the conference participant.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx account identifier for the participant.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the conference identifier.
        /// </summary>
        [JsonPropertyName("conference_id")]
        public string ConferenceId { get; set; }

        /// <summary>
        /// Gets or sets the time when the participant joined the conference.
        /// </summary>
        [JsonPropertyName("joined_at")]
        public DateTime JoinedAt { get; set; }

        /// <summary>
        /// Gets or sets the time when the participant left the conference.
        /// </summary>
        [JsonPropertyName("left_at")]
        public DateTime? LeftAt { get; set; }

        /// <summary>
        /// Gets or sets the destination number called by the participant.
        /// </summary>
        [JsonPropertyName("destination_number")]
        public string DestinationNumber { get; set; }

        /// <summary>
        /// Gets or sets the originating number used by the participant.
        /// </summary>
        [JsonPropertyName("originating_number")]
        public string OriginatingNumber { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx UUID for the call leg.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string CallLegId { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx UUID for the call session.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string CallSessionId { get; set; }

        /// <summary>
        /// Gets or sets the call duration in seconds.
        /// </summary>
        [JsonPropertyName("call_sec")]
        public int CallSec { get; set; }

        /// <summary>
        /// Gets or sets the billing duration in seconds.
        /// </summary>
        [JsonPropertyName("billed_sec")]
        public int BilledSec { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Telnyx billing applies.
        /// </summary>
        [JsonPropertyName("is_telnyx_billable")]
        public bool IsTelnyxBillable { get; set; }

        /// <summary>
        /// Gets or sets the rate per billing unit.
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Gets or sets the unit in which the rate is measured.
        /// </summary>
        [JsonPropertyName("rate_measured_in")]
        public string RateMeasuredIn { get; set; }

        /// <summary>
        /// Gets or sets the cost associated with the conference participation.
        /// </summary>
        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// Gets or sets the currency used for billing.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }

    /// <summary>
    /// Represents an AMD (Automated Media Distribution) detail record.
    /// Contains information related to a feature invocation.
    /// </summary>
    public class AmdDetailRecord : DetailRecordBase
    {
        /// <summary>
        /// Gets or sets the unique identifier of the AMD record.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the time when the feature was invoked.
        /// </summary>
        [JsonPropertyName("invoked_at")]
        public DateTime InvokedAt { get; set; }

        /// <summary>
        /// Gets or sets the feature name.
        /// </summary>
        [JsonPropertyName("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// Gets or sets the user-provided tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or sets the billing group identifier.
        /// </summary>
        [JsonPropertyName("billing_group_id")]
        public string BillingGroupId { get; set; }

        /// <summary>
        /// Gets or sets the billing group name.
        /// </summary>
        [JsonPropertyName("billing_group_name")]
        public string BillingGroupName { get; set; }

        /// <summary>
        /// Gets or sets the connection identifier.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the connection name.
        /// </summary>
        [JsonPropertyName("connection_name")]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx UUID for the call leg.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string CallLegId { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx UUID for the call session.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string CallSessionId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Telnyx billing applies.
        /// </summary>
        [JsonPropertyName("is_telnyx_billable")]
        public bool IsTelnyxBillable { get; set; }

        /// <summary>
        /// Gets or sets the rate per billing unit.
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Gets or sets the unit in which the rate is measured.
        /// </summary>
        [JsonPropertyName("rate_measured_in")]
        public string RateMeasuredIn { get; set; }

        /// <summary>
        /// Gets or sets the cost associated with the feature invocation.
        /// </summary>
        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// Gets or sets the currency used for billing.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }

    /// <summary>
    /// Represents a verification (2FA) detail record.
    /// Contains information about a verification process.
    /// </summary>
    public class VerificationDetailRecord : DetailRecordBase
    {
        /// <summary>
        /// Gets or sets the unique identifier for the verification.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the verification profile identifier.
        /// </summary>
        [JsonPropertyName("verify_profile_id")]
        public string VerifyProfileId { get; set; }

        /// <summary>
        /// Gets or sets the delivery status of the verification.
        /// </summary>
        [JsonPropertyName("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// Gets or sets the overall verification status.
        /// </summary>
        [JsonPropertyName("verification_status")]
        public string VerificationStatus { get; set; }

        /// <summary>
        /// Gets or sets the destination phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("destination_phone_number")]
        public string DestinationPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of verification channel (e.g., sms, call).
        /// </summary>
        [JsonPropertyName("verify_channel_type")]
        public string VerifyChannelType { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the verification channel.
        /// </summary>
        [JsonPropertyName("verify_channel_id")]
        public string VerifyChannelId { get; set; }

        /// <summary>
        /// Gets or sets the time when the verification was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the time when the verification was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the rate charged per billing unit.
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Gets or sets the unit in which the rate is measured.
        /// </summary>
        [JsonPropertyName("rate_measured_in")]
        public string RateMeasuredIn { get; set; }

        /// <summary>
        /// Gets or sets the usage fee for the verification.
        /// </summary>
        [JsonPropertyName("verify_usage_fee")]
        public string VerifyUsageFee { get; set; }

        /// <summary>
        /// Gets or sets the currency used for billing.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }

    /// <summary>
    /// Represents a SIM Card Usage detail record.
    /// Contains usage data for SIM card activity.
    /// </summary>
    public class SimCardUsageDetailRecord : DetailRecordBase
    {
        /// <summary>
        /// Gets or sets the unique identifier for this SIM card usage record.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the usage event.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the time when the usage event was closed.
        /// </summary>
        [JsonPropertyName("closed_at")]
        public DateTime ClosedAt { get; set; }

        /// <summary>
        /// Gets or sets the IP address that generated the event.
        /// </summary>
        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the number of megabytes downloaded.
        /// </summary>
        [JsonPropertyName("downlink_data")]
        public double DownlinkData { get; set; }

        /// <summary>
        /// Gets or sets the International Mobile Subscriber Identity.
        /// </summary>
        [JsonPropertyName("imsi")]
        public string Imsi { get; set; }

        /// <summary>
        /// Gets or sets the Mobile Country Code.
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// Gets or sets the Mobile Network Code.
        /// </summary>
        [JsonPropertyName("mnc")]
        public string Mnc { get; set; }

        /// <summary>
        /// Gets or sets the currency used for billing.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the unit in which data consumption is measured.
        /// </summary>
        [JsonPropertyName("data_unit")]
        public string DataUnit { get; set; }

        /// <summary>
        /// Gets or sets the rate charged per data unit.
        /// </summary>
        [JsonPropertyName("data_rate")]
        public string DataRate { get; set; }

        /// <summary>
        /// Gets or sets the SIM group name.
        /// </summary>
        [JsonPropertyName("sim_group_name")]
        public string SimGroupName { get; set; }

        /// <summary>
        /// Gets or sets the SIM card identifier.
        /// </summary>
        [JsonPropertyName("sim_card_id")]
        public string SimCardId { get; set; }

        /// <summary>
        /// Gets or sets the SIM group identifier.
        /// </summary>
        [JsonPropertyName("sim_group_id")]
        public string SimGroupId { get; set; }

        /// <summary>
        /// Gets or sets the user-provided tags.
        /// </summary>
        [JsonPropertyName("sim_card_tags")]
        public string SimCardTags { get; set; }

        /// <summary>
        /// Gets or sets the telephone number associated with the SIM card.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the number of megabytes uploaded.
        /// </summary>
        [JsonPropertyName("uplink_data")]
        public double UplinkData { get; set; }

        /// <summary>
        /// Gets or sets the cost for the data used.
        /// </summary>
        [JsonPropertyName("data_cost")]
        public double DataCost { get; set; }
    }

    /// <summary>
    /// Represents a Media Storage detail record.
    /// Contains information about a media storage event.
    /// </summary>
    public class MediaStorageDetailRecord : DetailRecordBase
    {
        /// <summary>
        /// Gets or sets the unique identifier for the media storage event.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the time when the event was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the asset identifier.
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx account identifier associated with the asset.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the organization identifier.
        /// </summary>
        [JsonPropertyName("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// Gets or sets the type of action performed.
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// Gets or sets the link channel type.
        /// </summary>
        [JsonPropertyName("link_channel_type")]
        public string LinkChannelType { get; set; }

        /// <summary>
        /// Gets or sets the link channel identifier.
        /// </summary>
        [JsonPropertyName("link_channel_id")]
        public string LinkChannelId { get; set; }

        /// <summary>
        /// Gets or sets the status of the media storage event.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the webhook identifier associated with the event.
        /// </summary>
        [JsonPropertyName("webhook_id")]
        public string WebhookId { get; set; }

        /// <summary>
        /// Gets or sets the rate charged per billing unit.
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Gets or sets the unit in which the rate is measured.
        /// </summary>
        [JsonPropertyName("rate_measured_in")]
        public string RateMeasuredIn { get; set; }

        /// <summary>
        /// Gets or sets the cost associated with the media storage event.
        /// </summary>
        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// Gets or sets the currency used for billing.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}