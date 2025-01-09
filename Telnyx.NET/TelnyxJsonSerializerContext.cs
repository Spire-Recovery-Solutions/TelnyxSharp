using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;
using Telnyx.NET.Messaging.Events;
using Telnyx.NET.Messaging.Models;
using Telnyx.NET.Messaging.Models.AdvancedOptInOptOut;
using Telnyx.NET.Messaging.Models.AdvancedOptInOptOut.Requests;
using Telnyx.NET.Messaging.Models.AdvancedOptInOptOut.Responses;
using Telnyx.NET.Messaging.Models.Brands;
using Telnyx.NET.Messaging.Models.Brands.Requests;
using Telnyx.NET.Messaging.Models.Brands.Responses;
using Telnyx.NET.Messaging.Models.BulkPhoneNumberCampaign.Requests;
using Telnyx.NET.Messaging.Models.BulkPhoneNumberCampaign.Responses;
using Telnyx.NET.Messaging.Models.Campaign.Requests;
using Telnyx.NET.Messaging.Models.Campaign.Responses;
using Telnyx.NET.Messaging.Models.Enums.Responses;
using Telnyx.NET.Messaging.Models.Messages.Requests;
using Telnyx.NET.Messaging.Models.Messages.Responses;
using Telnyx.NET.Messaging.Models.MessagesProfile;
using Telnyx.NET.Messaging.Models.MessagesProfile.Requests;
using Telnyx.NET.Messaging.Models.MessagesProfile.Responses;
using Telnyx.NET.Messaging.Models.MessagingHostedNumber;
using Telnyx.NET.Messaging.Models.MessagingHostedNumber.Requests;
using Telnyx.NET.Messaging.Models.MessagingHostedNumber.Responses;
using Telnyx.NET.Messaging.Models.MessagingUrlDomain.Requests;
using Telnyx.NET.Messaging.Models.MessagingUrlDomain.Responses;
using Telnyx.NET.Messaging.Models.NumberConfigurations.Requests;
using Telnyx.NET.Messaging.Models.NumberConfigurations.Responses;
using Telnyx.NET.Messaging.Models.PhoneNumberCampaign.Requests;
using Telnyx.NET.Messaging.Models.PhoneNumberCampaign.Responses;
using Telnyx.NET.Messaging.Models.SharedCampaign;
using Telnyx.NET.Messaging.Models.SharedCampaign.Requests;
using Telnyx.NET.Messaging.Models.SharedCampaign.Responses;
using Telnyx.NET.Messaging.Models.ShortCodes.Requests;
using Telnyx.NET.Messaging.Models.ShortCodes.Responses;
using Telnyx.NET.Messaging.Models.TollFreeVerificationOperations;
using Telnyx.NET.Messaging.Models.TollFreeVerificationOperations.Requests;
using Telnyx.NET.Messaging.Models.TollFreeVerificationOperations.Responses;
using Telnyx.NET.Models;
using Telnyx.NET.Models.Events;
using Telnyx.NET.PhoneNumber.Models.Identity.Requests;
using Telnyx.NET.PhoneNumber.Models.Identity.Responses;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;
using Telnyx.NET.Voice.Models.CallCommands.Requests;
using Telnyx.NET.Voice.Models.CallCommands.Responses;

namespace Telnyx.NET
{
    [JsonSerializable(typeof(AvailablePhoneNumbersResponse))]
    [JsonSerializable(typeof(AvailablePhoneNumbersDatum))]
    [JsonSerializable(typeof(CostInformation))]
    [JsonSerializable(typeof(Feature))]
    [JsonSerializable(typeof(RegionInformation))]
    [JsonSerializable(typeof(AvailablePhoneNumbersMeta))]
    [JsonSerializable(typeof(AvailablePhoneNumbersRequest))]
    [JsonSerializable(typeof(CreateNumberOrderRegulatoryRequirement))]
    [JsonSerializable(typeof(CreateNumberOrderRequest))]
    [JsonSerializable(typeof(CreateNumberOrderPhoneNumber))]
    [JsonSerializable(typeof(CreateNumberOrderResponse))]
    [JsonSerializable(typeof(CreateNumberOrderResponseData))]
    [JsonSerializable(typeof(CreateNumberOrderResponsePhoneNumber))]
    [JsonSerializable(typeof(CreateNumberReservationRequest))]
    [JsonSerializable(typeof(CreateNumberReservationPhoneNumber))]
    [JsonSerializable(typeof(CreateNumberReservationResponse))]
    [JsonSerializable(typeof(CreateNumberReservationResponseData))]
    [JsonSerializable(typeof(CreateNumberReservationResponsePhoneNumber))]
    [JsonSerializable(typeof(GetNumberOrderResponse))]
    [JsonSerializable(typeof(ListNumberOrdersResponse))]
    [JsonSerializable(typeof(NumberOrdersPhoneNumber))]
    [JsonSerializable(typeof(ListNumberOrdersRequest))]
    [JsonSerializable(typeof(ListNumbersRequest))]
    [JsonSerializable(typeof(ListNumbersResponse))]
    [JsonSerializable(typeof(ListNumbersDatum))]
    [JsonSerializable(typeof(ListPortingOrdersRequest))]
    [JsonSerializable(typeof(PortingOrdersRequest))]
    [JsonSerializable(typeof(ListPortingOrdersResponse))]
    [JsonSerializable(typeof(ListPortingOrdersDatum))]
    [JsonSerializable(typeof(ListPortingOrdersActivationSettings))]
    [JsonSerializable(typeof(ListPortingOrdersDocuments))]
    [JsonSerializable(typeof(ListPortingOrdersEndUser))]
    [JsonSerializable(typeof(ListPortingOrdersAdmin))]
    [JsonSerializable(typeof(ListPortingOrdersLocation))]
    [JsonSerializable(typeof(ListPortingOrdersMisc))]
    [JsonSerializable(typeof(ListPortingOrdersPhoneNumberConfiguration))]
    [JsonSerializable(typeof(ListPortingOrdersPhoneNumber))]
    [JsonSerializable(typeof(ListPortingOrdersStatus))]
    [JsonSerializable(typeof(ListPortingOrdersDetail))]
    [JsonSerializable(typeof(ListPortingOrdersUserFeedback))]

    [JsonSerializable(typeof(ListPortingPhoneNumbersRequest))]
    [JsonSerializable(typeof(ListPortingPhoneNumbersResponse))]
    [JsonSerializable(typeof(ListPortingPhoneNumbersDatum))]


    [JsonSerializable(typeof(NumberLookupRequest))]
    [JsonSerializable(typeof(NumberLookupResponse))]
    [JsonSerializable(typeof(NumberLookupDatum))]
    [JsonSerializable(typeof(NumberLookupCallerName))]
    [JsonSerializable(typeof(NumberLookupCarrier))]
    [JsonSerializable(typeof(NumberLookupPortability))]
    [JsonSerializable(typeof(NumberOrder))]
    [JsonSerializable(typeof(SendMessageRequest))]
    [JsonSerializable(typeof(SendMessageResponse))]
    [JsonSerializable(typeof(SendMessageData))]
    [JsonSerializable(typeof(Cost))]
    [JsonSerializable(typeof(FromTo))]
    [JsonSerializable(typeof(Media))]
    [JsonSerializable(typeof(TelnyxRateLimitConfiguration))]
    [JsonSerializable(typeof(UpdateNumberConfigurationRequest))]
    [JsonSerializable(typeof(UpdateNumberConfigurationResponse))]
    [JsonSerializable(typeof(UpdateNumberConfigurationResponseData))]
    [JsonSerializable(typeof(UpdateNumberVoiceSettingsRequest))]
    [JsonSerializable(typeof(UpdateNumberVoiceSettingsResponse))]
    [JsonSerializable(typeof(UpdateNumberVoiceSettingsData))]
    [JsonSerializable(typeof(UpdateNumberVoiceSettingsCallForwarding))]
    [JsonSerializable(typeof(UpdateNumberVoiceSettingsCallRecording))]
    [JsonSerializable(typeof(UpdateNumberVoiceSettingsCnamListing))]
    [JsonSerializable(typeof(UpdateNumberVoiceSettingsEmergency))]
    [JsonSerializable(typeof(UpdateNumberVoiceSettingsMediaFeatures))]



    [JsonSerializable(typeof(DialRequest))]
    [JsonSerializable(typeof(DialResponse))]
    [JsonSerializable(typeof(DialDialogflowConfig))]
    [JsonSerializable(typeof(DialResponseData))]
    [JsonSerializable(typeof(AnsweringMachineDetectionConfig))]
    [JsonSerializable(typeof(ConferenceConfig))]
    [JsonSerializable(typeof(CustomHeader))]
    [JsonSerializable(typeof(SipHeader))]
    [JsonSerializable(typeof(SoundModifications))]
    [JsonSerializable(typeof(TranscriptionConfig))]


    [JsonSerializable(typeof(AnswerCallResponse))]
    [JsonSerializable(typeof(AnswerCallResponseData))]
    [JsonSerializable(typeof(AnswerCallRequest))]


    [JsonSerializable(typeof(HangupCallRequest))]
    [JsonSerializable(typeof(HangupCallResponse))]
    [JsonSerializable(typeof(HangupCallResponseData))]


    [JsonSerializable(typeof(RejectCallResponse))]
    [JsonSerializable(typeof(RejectCallResponseData))]
    [JsonSerializable(typeof(RejectCallRequest))]
    [JsonSerializable(typeof(RejectCallCause))]

    [JsonSerializable(typeof(SpeakTextRequest))]
    [JsonSerializable(typeof(SpeakTextResponse))]
    [JsonSerializable(typeof(SpeakTextResponseData))]

    [JsonSerializable(typeof(PlaybackStartRequest))]
    [JsonSerializable(typeof(PlaybackStartResponse))]
    [JsonSerializable(typeof(PlaybackStartResponseData))]

    [JsonSerializable(typeof(StopAudioPlaybackRequest))]
    [JsonSerializable(typeof(StopAudioPlaybackResponse))]
    [JsonSerializable(typeof(StopAudioPlaybackResponseData))]

    [JsonSerializable(typeof(EnqueueCallRequest))]
    [JsonSerializable(typeof(EnqueueCallResponse))]
    [JsonSerializable(typeof(EnqueueCallResponseData))]

    [JsonSerializable(typeof(RemoveCallFromQueueRequest))]
    [JsonSerializable(typeof(RemoveCallFromQueueResponse))]
    [JsonSerializable(typeof(RemoveCallFromQueueResponseData))]

    [JsonSerializable(typeof(TransferCallRequest))]
    [JsonSerializable(typeof(TransferCallResponse))]
    [JsonSerializable(typeof(TransferCallResponseData))]

    [JsonSerializable(typeof(MessagingProfileBase))]
    [JsonSerializable(typeof(MessagingProfilesRequest))]
    [JsonSerializable(typeof(MessagingProfilesResponse))]
    [JsonSerializable(typeof(MessagingProfile))]
    [JsonSerializable(typeof(UrlShortenerSettings))]

    [JsonSerializable(typeof(CreateMessagingProfileRequest))]
    [JsonSerializable(typeof(CreateMessagingProfileResponse))]
    [JsonSerializable(typeof(CreateMessagingProfileData))]

    [JsonSerializable(typeof(RetrieveMessagingProfileResponse))]
    [JsonSerializable(typeof(RetrieveMessagingProfileData))]

    [JsonSerializable(typeof(UpdateMessagingProfileRequest))]
    [JsonSerializable(typeof(UpdateMessagingProfileResponse))]
    [JsonSerializable(typeof(UpdateMessagingProfileData))]

    [JsonSerializable(typeof(DeleteMessagingProfileResponse))]
    [JsonSerializable(typeof(DeleteMessagingProfileData))]

    [JsonSerializable(typeof(MessagingProfilePhoneNumberRequest))]
    [JsonSerializable(typeof(MessagingProfilePhoneNumberResponse))]
    [JsonSerializable(typeof(MessagingProfilePhoneNumberData))]
    [JsonSerializable(typeof(MessagingPhoneNumberHealth))]
    [JsonSerializable(typeof(MessagingPhoneNumberFeatures))]
    [JsonSerializable(typeof(MessagingFeature))]

    [JsonSerializable(typeof(MessagingProfileShortCodeRequest))]
    [JsonSerializable(typeof(MessagingProfileShortCodeResponse))]
    [JsonSerializable(typeof(MessagingProfileShortCode))]

    [JsonSerializable(typeof(RetrieveMessagingProfileMetricsRequest))]
    [JsonSerializable(typeof(RetrieveMessagingProfileMetricsResponse))]
    [JsonSerializable(typeof(RetrieveMessagingProfileMetricsData))]
    [JsonSerializable(typeof(MessagingProfileMetricsOverview))]
    [JsonSerializable(typeof(MessagingProfileDetailedMetric))]
    [JsonSerializable(typeof(MessagingProfileMetricDetail))]
    [JsonSerializable(typeof(MessagingProfileOutboundMetrics))]
    [JsonSerializable(typeof(MessagingProfileInboundMetrics))]

    [JsonSerializable(typeof(MessagingProfileMetricsRequest))]
    [JsonSerializable(typeof(MessagingProfileMetricsResponse))]
    [JsonSerializable(typeof(MessagingProfileMetricsData))]

    [JsonSerializable(typeof(MessageBaseRequest))]
    [JsonSerializable(typeof(MessageBaseResponse))]

    [JsonSerializable(typeof(LongCodeMessageRequest))]
    [JsonSerializable(typeof(LongCodeMessageResponse))]
    [JsonSerializable(typeof(LongCodeMessageData))]

    [JsonSerializable(typeof(NumberPoolMessageRequest))]
    [JsonSerializable(typeof(NumberPoolMessageResponse))]
    [JsonSerializable(typeof(NumberPoolMessageData))]

    [JsonSerializable(typeof(ShortCodeMessageData))]
    [JsonSerializable(typeof(ShortCodeMessageRequest))]
    [JsonSerializable(typeof(ShortCodeMessageResponse))]

    [JsonSerializable(typeof(GroupMmsMessageRequest))]
    [JsonSerializable(typeof(GroupMmsMessageResponse))]
    [JsonSerializable(typeof(GroupMmsMessageData))]

    [JsonSerializable(typeof(RetrieveMessageResponse))]
    [JsonSerializable(typeof(RetrieveMessageData))]

    [JsonSerializable(typeof(ListMessagingUrlDomainsRequest))]
    [JsonSerializable(typeof(ListMessagingUrlDomainsResponse))]
    [JsonSerializable(typeof(MessagingUrlDomain))]

    [JsonSerializable(typeof(ListShortCodesRequest))]
    [JsonSerializable(typeof(ListShortCodesResponse))]
    [JsonSerializable(typeof(ShortCode))]

    [JsonSerializable(typeof(RetrieveShortCodeResponse))]
    [JsonSerializable(typeof(ShortCodeDetail))]


    [JsonSerializable(typeof(UpdateShortCodeRequest))]
    [JsonSerializable(typeof(UpdateShortCodeResponse))]
    [JsonSerializable(typeof(ShortCodeDetail))]

    [JsonSerializable(typeof(ListPhoneMessageSettingsRequest))]
    [JsonSerializable(typeof(ListPhoneMessageSettingsResponse))]
    [JsonSerializable(typeof(PhoneNumberMessagingSettings))]

    [JsonSerializable(typeof(RetrievePhoneMessageSettingsResponse))]
    [JsonSerializable(typeof(RetrievePhoneMessageSettings))]

    [JsonSerializable(typeof(UpdatePhoneNumberMessagingRequest))]
    [JsonSerializable(typeof(UpdatePhoneNumberMessagingResponse))]
    [JsonSerializable(typeof(UpdatePhoneNumberMessaging))]

    [JsonSerializable(typeof(UpdateNumbersMessagingBulkRequest))]
    [JsonSerializable(typeof(UpdateNumbersMessagingBulkResponse))]
    [JsonSerializable(typeof(UpdateNumbersMessagingBulk))]

    [JsonSerializable(typeof(RetrieveBulkUpdateStatusResponse))]
    [JsonSerializable(typeof(RetrieveBulkUpdateStatus))]

    [JsonSerializable(typeof(BaseHostedNumberOrderData))]

    [JsonSerializable(typeof(DeleteHostedNumberResponse))]
    [JsonSerializable(typeof(DeleteHostedNumberData))]

    [JsonSerializable(typeof(GetHostedNumberOrderRequest))]
    [JsonSerializable(typeof(GetHostedNumberOrderResponse))]
    [JsonSerializable(typeof(HostedNumberOrderData))]
    [JsonSerializable(typeof(HostedPhoneNumber))]

    [JsonSerializable(typeof(CreateHostedNumberOrderRequest))]
    [JsonSerializable(typeof(CreateHostedNumberOrderResponse))]
    [JsonSerializable(typeof(CreateHostedNumberOrder))]

    [JsonSerializable(typeof(RetrieveHostedNumberOrderResponse))]
    [JsonSerializable(typeof(RetrieveHostedNumberOrderData))]

    [JsonSerializable(typeof(UploadFileHostedNumberOrderRequest))]
    [JsonSerializable(typeof(UploadFileHostedNumberOrderResponse))]
    [JsonSerializable(typeof(UploadFileHostedNumberOrderData))]

    [JsonSerializable(typeof(BaseAutoResponseSetting))]

    [JsonSerializable(typeof(ListAutoResponseSettingsRequest))]
    [JsonSerializable(typeof(ListAutoResponseSettingsResponse))]
    [JsonSerializable(typeof(AutoResponseSetting))]

    [JsonSerializable(typeof(CreateAutoResponseSettingRequest))]
    [JsonSerializable(typeof(CreateAutoResponseSettingResponse))]
    [JsonSerializable(typeof(CreateAutoResponseSetting))]

    [JsonSerializable(typeof(GetAutoResponseSettingResponse))]
    [JsonSerializable(typeof(GetAutoResponseSetting))]

    [JsonSerializable(typeof(UpdateAutoResponseSettingRequest))]
    [JsonSerializable(typeof(UpdateAutoResponseSettingResponse))]
    [JsonSerializable(typeof(UpdateAutoResponseSetting))]

    [JsonSerializable(typeof(DeleteAutoResponseSettingResponse))]

    [JsonSerializable(typeof(BaseVerificationRequestResponse))]

    [JsonSerializable(typeof(ListVerificationRequestsRequest))]
    [JsonSerializable(typeof(ListVerificationRequestsResponse))]
    [JsonSerializable(typeof(VerificationRequestRecord))]
    [JsonSerializable(typeof(Messaging.Models.TollFreeVerificationOperations.PhoneNumber))]
    [JsonSerializable(typeof(OptInWorkflowImage))]

    [JsonSerializable(typeof(SubmitVerificationRequestRequest))]
    [JsonSerializable(typeof(SubmitVerificationRequestResponse))]

    [JsonSerializable(typeof(GetVerificationRequestResponse))]

    [JsonSerializable(typeof(DeleteVerificationRequestResponse))]

    [JsonSerializable(typeof(UpdateVerificationRequestRequest))]
    [JsonSerializable(typeof(UpdateVerificationRequestResponse))]

    [JsonSerializable(typeof(ValidationErrorDetail))]
    [JsonSerializable(typeof(BaseBrandResponse))]

    [JsonSerializable(typeof(ListBrandsRequest))]
    [JsonSerializable(typeof(ListBrandsResponse))]
    [JsonSerializable(typeof(BrandRecord))]

    [JsonSerializable(typeof(CreateBrandRequest))]
    [JsonSerializable(typeof(CreateBrandResponse))]
    [JsonSerializable(typeof(OptionalAttributes))]

    [JsonSerializable(typeof(GetBrandResponse))]

    [JsonSerializable(typeof(UpdateBrandRequest))]
    [JsonSerializable(typeof(UpdateBrandResponse))]

    [JsonSerializable(typeof(DeleteBrandResponse))]

    [JsonSerializable(typeof(ResendBrand2FAEmailResponse))]

    [JsonSerializable(typeof(RevetBrandResponse))]

    [JsonSerializable(typeof(ListExternalVettingResponse))]

    [JsonSerializable(typeof(ImportExternalVettingRequest))]
    [JsonSerializable(typeof(ImportExternalVettingResponse))]

    [JsonSerializable(typeof(OrderExternalVettingRequest))]
    [JsonSerializable(typeof(OrderExternalVettingResponse))]

    [JsonSerializable(typeof(GetBrandFeedbackResponse))]
    [JsonSerializable(typeof(Category))]

    [JsonSerializable(typeof(ListCampaignsRequest))]
    [JsonSerializable(typeof(ListCampaignsResponse))]
    [JsonSerializable(typeof(CampaignRecord))]

    [JsonSerializable(typeof(GetCampaignResponse))]

    [JsonSerializable(typeof(UpdateCampaignRequest))]
    [JsonSerializable(typeof(UpdateCampaignResponse))]

    [JsonSerializable(typeof(DeactivateCampaignResponse))]

    [JsonSerializable(typeof(GetCampaignOperationStatusResponse))]

    [JsonSerializable(typeof(GetCampaignOsrAttributesResponse))]

    [JsonSerializable(typeof(GetCampaignCostRequest))]
    [JsonSerializable(typeof(GetCampaignCostResponse))]

    [JsonSerializable(typeof(SubmitCampaignRequest))]
    [JsonSerializable(typeof(SubmitCampaignResponse))]

    [JsonSerializable(typeof(QualifyCampaignByUsecaseResponse))]

    [JsonSerializable(typeof(AcceptSharedCampaignResponse))]

    [JsonSerializable(typeof(GetCampaignMnoMetadataResponse))]
    [JsonSerializable(typeof(MnoMetadataDetail))]

    [JsonSerializable(typeof(GetCampaignSharingStatusResponse))]
    [JsonSerializable(typeof(SharingStatusDetail))]

    [JsonSerializable(typeof(RetrievePhoneNumberCampaignsRequest))]
    [JsonSerializable(typeof(RetrievePhoneNumberCampaignsResponse))]
    [JsonSerializable(typeof(RetrievePhoneNumberCampaign))]

    [JsonSerializable(typeof(CreatePhoneNumberCampaignRequest))]
    [JsonSerializable(typeof(CreatePhoneNumberCampaignResponse))]

    [JsonSerializable(typeof(GetPhoneNumberCampaignResponse))]

    [JsonSerializable(typeof(UpdatePhoneNumberCampaignRequest))]
    [JsonSerializable(typeof(UpdatePhoneNumberCampaignResponse))]

    [JsonSerializable(typeof(DeletePhoneNumberCampaignResponse))]

    [JsonSerializable(typeof(AssignMessagingProfileToCampaignRequest))]
    [JsonSerializable(typeof(AssignMessagingProfileToCampaignResponse))]

    [JsonSerializable(typeof(GetPhoneNumberStatusResponse))]
    [JsonSerializable(typeof(PhoneNumberStatusRecord))]
    [JsonSerializable(typeof(GetPhoneNumberStatusRequest))]

    [JsonSerializable(typeof(GetAssignmentTaskStatusResponse))]

    [JsonSerializable(typeof(BaseSharedCampaigns))]

    [JsonSerializable(typeof(ListSharedCampaignsRequest))]
    [JsonSerializable(typeof(ListSharedCampaignsResponse))]
    [JsonSerializable(typeof(SharedCampaignRecord))]

    [JsonSerializable(typeof(GetSharedCampaignRecordResponse))]

    [JsonSerializable(typeof(UpdateSingleSharedCampaignRequest))]
    [JsonSerializable(typeof(UpdateSingleSharedCampaignResponse))]

    [JsonSerializable(typeof(GetSharingStatusResponse))]

    [JsonSerializable(typeof(GetPartnerCampaignsSharedByUserRequest))]
    [JsonSerializable(typeof(GetPartnerCampaignsSharedByUserResponse))]
    [JsonSerializable(typeof(PartnerCampaignsSharedByUser))]

    [JsonSerializable(typeof(GetEnumResponse))]


    //Enums
    [JsonSerializable(typeof(NumberLookupType))]
    [JsonSerializable(typeof(AltBusinessIdType))]
    [JsonSerializable(typeof(BrandIdentityStatus))]
    [JsonSerializable(typeof(BrandRelationship))]
    [JsonSerializable(typeof(CampaignStatus))]
    [JsonSerializable(typeof(EntityType))]
    [JsonSerializable(typeof(MessageDirection))]
    [JsonSerializable(typeof(MessageRecordType))]
    [JsonSerializable(typeof(MessageType))]
    [JsonSerializable(typeof(MessageVolume))]
    [JsonSerializable(typeof(OperationType))]
    [JsonSerializable(typeof(Sort))]
    [JsonSerializable(typeof(Status))]
    [JsonSerializable(typeof(StockExchange))]
    [JsonSerializable(typeof(TimeFrame))]
    [JsonSerializable(typeof(UseCaseCategories))]
    [JsonSerializable(typeof(VerificationStatus))]
    [JsonSerializable(typeof(Vertical))]

    //Events
    [JsonSerializable(typeof(TelnyxEvent))]
    [JsonSerializable(typeof(List<TelnyxEvent>))]
    [JsonSerializable(typeof(IEvent))]
    [JsonSerializable(typeof(BaseEvent))]
    [JsonSerializable(typeof(TelnyxEventMeta))]

    [JsonSerializable(typeof(CallAnsweredEvent))]
    [JsonSerializable(typeof(CallBridgedEvent))]
    // [JsonSerializable(typeof(CallDequeuedEvent))]
    [JsonSerializable(typeof(CallDtmfReceivedEvent))]
    [JsonSerializable(typeof(CallEnqueuedEvent))]
    [JsonSerializable(typeof(CallForkStartedEvent))]
    [JsonSerializable(typeof(CallForkStoppedEvent))]
    [JsonSerializable(typeof(CallGatherEndedEvent))]
    [JsonSerializable(typeof(CallHangupEvent))]
    [JsonSerializable(typeof(CallInitiatedEvent))]
    [JsonSerializable(typeof(CallMachineDetectionEndedEvent))]
    [JsonSerializable(typeof(CallMachineGreetingEndedEvent))]
    [JsonSerializable(typeof(CallMachinePremiumDetectionEndedEvent))]
    [JsonSerializable(typeof(CallMachinePremiumGreetingEndedEvent))]
    [JsonSerializable(typeof(CallPlaybackEndedEvent))]
    [JsonSerializable(typeof(CallPlaybackStartedEvent))]
    [JsonSerializable(typeof(CallRecordingErrorEvent))]
    [JsonSerializable(typeof(CallRecordingSavedEvent))]
    [JsonSerializable(typeof(CallReferCompletedEvent))]
    [JsonSerializable(typeof(CallReferFailedEvent))]
    [JsonSerializable(typeof(CallReferStartedEvent))]
    [JsonSerializable(typeof(CallSpeakEndedEvent))]
    [JsonSerializable(typeof(CallSpeakStartedEvent))]
    // [JsonSerializable(typeof(CallTranscriptionEvent))]
    [JsonSerializable(typeof(ConferenceCreatedEvent))]
    [JsonSerializable(typeof(ConferenceEndedEvent))]
    // [JsonSerializable(typeof(ConferenceFloorChangedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantJoinedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantLeftEvent))]
    [JsonSerializable(typeof(ConferenceParticipantPlaybackEndedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantPlaybackStartedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantSpeakEndedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantSpeakStartedEvent))]
    [JsonSerializable(typeof(ConferencePlaybackEndedEvent))]
    [JsonSerializable(typeof(ConferencePlaybackStartedEvent))]
    [JsonSerializable(typeof(ConferenceRecordingSavedEvent))]
    [JsonSerializable(typeof(ConferenceSpeakEndedEvent))]
    [JsonSerializable(typeof(ConferenceSpeakStartedEvent))]
    [JsonSerializable(typeof(MessageReceivedEvent))]
    [JsonSerializable(typeof(MessageSentEvent))]
    [JsonSerializable(typeof(MessageReceivedPayload))]
    [JsonSerializable(typeof(MessageFrom))]
    [JsonSerializable(typeof(MessageToCc))]
    [JsonSerializable(typeof(Cost))]
    [JsonSerializable(typeof(DeletePhoneNumberResponse))]
    [JsonSerializable(typeof(DeletePhoneNumberData))]
    // [JsonSerializable(typeof(StreamingFailedEvent))]
    // [JsonSerializable(typeof(StreamingStartedEvent))]
    // [JsonSerializable(typeof(StreamingStoppedEvent))]
    // [JsonSerializable(typeof(VideoRoomCompositionCompletedEvent))]
    // [JsonSerializable(typeof(VideoRoomRecordingStartedEvent))]
    // [JsonSerializable(typeof(VideoRoomSessionEndedEvent))]
    // [JsonSerializable(typeof(VideoRoomSessionStartedEvent))]


    [JsonSerializable(typeof(ITelnyxResponse))]
    [JsonSerializable(typeof(TelnyxResponse))]
    [JsonSerializable(typeof(TelnyxError))]
    [JsonSerializable(typeof(ErrorSource))]
    [JsonSerializable(typeof(TelnyxError[]))]
    [JsonSerializable(typeof(PaginationMeta))]
    [JsonSerializable(typeof(ValidationErrorDetail))]

    [JsonSourceGenerationOptions(
        UseStringEnumConverter = true,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
    public partial class TelnyxJsonSerializerContext : JsonSerializerContext
    {

    }
}
