using SRS.Data.Telnyx.Models.Events;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Models;
using Telnyx.NET.Models.Events;

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
    [JsonSerializable(typeof(ListNumberOrdersMeta))]
    [JsonSerializable(typeof(ListNumberOrdersRequest))]
    [JsonSerializable(typeof(ListNumbersRequest))]
    [JsonSerializable(typeof(ListNumbersResponse))]
    [JsonSerializable(typeof(ListNumbersDatum))]
    [JsonSerializable(typeof(ListNumbersMeta))]
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
    [JsonSerializable(typeof(ListPortingOrdersMeta))]

    [JsonSerializable(typeof(ListPortingPhoneNumbersRequest))]
    [JsonSerializable(typeof(ListPortingPhoneNumbersResponse))]
    [JsonSerializable(typeof(ListPortingPhoneNumbersDatum))]
    [JsonSerializable(typeof(ListPortingPhoneNumbersMeta))]


    [JsonSerializable(typeof(NumberLookupRequest))]
    [JsonSerializable(typeof(NumberLookupResponse))]
    [JsonSerializable(typeof(NumberLookupDatum))]
    [JsonSerializable(typeof(NumberLookupCallerName))]
    [JsonSerializable(typeof(NumberLookupCarrier))]
    [JsonSerializable(typeof(NumberLookupPortability))]
    [JsonSerializable(typeof(NumberLookupType))]
    [JsonSerializable(typeof(NumberOrder))]
    [JsonSerializable(typeof(NumberOrdersRequest))]
    [JsonSerializable(typeof(NumberReservationRequest))]
    [JsonSerializable(typeof(PhoneNumbersRequest))]
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

    [JsonSerializable(typeof(TelnyxError))]
    [JsonSerializable(typeof(ErrorSource))]
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
    [JsonSerializable(typeof(MessagingProfilesMeta))]

    [JsonSerializable(typeof(CreateMessagingProfileRequest))]
    [JsonSerializable(typeof(CreateMessagingProfileResponse))]
    [JsonSerializable(typeof(CreateMessagingProfileData))]

    [JsonSerializable(typeof(RetrieveMessagingProfileRequest))]
    [JsonSerializable(typeof(RetrieveMessagingProfileResponse))]
    [JsonSerializable(typeof(RetrieveMessagingProfileData))]

    [JsonSerializable(typeof(UpdateMessagingProfileRequest))]
    [JsonSerializable(typeof(UpdateMessagingProfileResponse))]
    [JsonSerializable(typeof(UpdateMessagingProfileData))]

    [JsonSerializable(typeof(DeleteMessagingProfileRequest))]
    [JsonSerializable(typeof(DeleteMessagingProfileResponse))]
    [JsonSerializable(typeof(DeleteMessagingProfileData))]

    [JsonSerializable(typeof(MessagingProfilePhoneNumberRequest))]
    [JsonSerializable(typeof(MessagingProfilePhoneNumberResponse))]
    [JsonSerializable(typeof(MessagingProfilePhoneNumberData))]
    [JsonSerializable(typeof(MessagingPhoneNumberHealth))]
    [JsonSerializable(typeof(MessagingPhoneNumberFeatures))]
    [JsonSerializable(typeof(MessagingFeature))]
    [JsonSerializable(typeof(MessagingProfilePhoneNumberMeta))]

    [JsonSerializable(typeof(MessagingProfileShortCodeRequest))]
    [JsonSerializable(typeof(MessagingProfileShortCodeResponse))]
    [JsonSerializable(typeof(MessagingProfileShortCode))]
    [JsonSerializable(typeof(MessagingProfileShortCodeMeta))]

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
    [JsonSerializable(typeof(MessagingProfileMetricsMeta))]

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

    [JsonSerializable(typeof(RetrieveMessageRequest))]
    [JsonSerializable(typeof(RetrieveMessageResponse))]
    [JsonSerializable(typeof(RetrieveMessageData))]

    [JsonSerializable(typeof(ListMessagingUrlDomainsRequest))]
    [JsonSerializable(typeof(ListMessagingUrlDomainsResponse))]
    [JsonSerializable(typeof(ListMessagingUrlDomainsMeta))]
    [JsonSerializable(typeof(MessagingUrlDomain))]

    [JsonSerializable(typeof(ListShortCodesRequest))]
    [JsonSerializable(typeof(ListShortCodesResponse))]
    [JsonSerializable(typeof(ShortCode))]
    [JsonSerializable(typeof(ListShortCodesMeta))]

    [JsonSerializable(typeof(RetrieveShortCodeRequest))]
    [JsonSerializable(typeof(RetrieveShortCodeResponse))]
    [JsonSerializable(typeof(ShortCodeDetail))]


    [JsonSerializable(typeof(UpdateShortCodeRequest))]
    [JsonSerializable(typeof(UpdateShortCodeResponse))]
    [JsonSerializable(typeof(ShortCodeDetail))]

    [JsonSerializable(typeof(ListPhoneMessageSettingsRequest))]
    [JsonSerializable(typeof(ListPhoneMessageSettingsResponse))]
    [JsonSerializable(typeof(PhoneNumberMessagingSettings))]
    [JsonSerializable(typeof(ListPhoneMessageSettingsMeta))]

    [JsonSerializable(typeof(RetrievePhoneMessageSettingsRequest))]
    [JsonSerializable(typeof(RetrievePhoneMessageSettingsResponse))]
    [JsonSerializable(typeof(RetrievePhoneMessageSettings))]

    [JsonSerializable(typeof(UpdatePhoneNumberMessagingRequest))]
    [JsonSerializable(typeof(UpdatePhoneNumberMessagingResponse))]
    [JsonSerializable(typeof(UpdatePhoneNumberMessaging))]

    [JsonSerializable(typeof(UpdateNumbersMessagingBulkRequest))]
    [JsonSerializable(typeof(UpdateNumbersMessagingBulkResponse))]
    [JsonSerializable(typeof(UpdateNumbersMessagingBulk))]

    [JsonSerializable(typeof(RetrieveBulkUpdateStatusRequest))]
    [JsonSerializable(typeof(RetrieveBulkUpdateStatusResponse))]
    [JsonSerializable(typeof(RetrieveBulkUpdateStatus))]

    [JsonSerializable(typeof(BaseHostedNumberOrderData))]

    [JsonSerializable(typeof(DeleteHostedNumberRequest))]
    [JsonSerializable(typeof(DeleteHostedNumberResponse))]
    [JsonSerializable(typeof(DeleteHostedNumberData))]

    [JsonSerializable(typeof(GetHostedNumberOrderRequest))]
    [JsonSerializable(typeof(GetHostedNumberOrderResponse))]
    [JsonSerializable(typeof(HostedNumberOrderData))]
    [JsonSerializable(typeof(HostedPhoneNumber))]
    [JsonSerializable(typeof(HostedNumberOrderMeta))]

    [JsonSerializable(typeof(CreateHostedNumberOrderRequest))]
    [JsonSerializable(typeof(CreateHostedNumberOrderResponse))]
    [JsonSerializable(typeof(CreateHostedNumberOrder))]

    [JsonSerializable(typeof(RetrieveHostedNumberOrderRequest))]
    [JsonSerializable(typeof(RetrieveHostedNumberOrderResponse))]
    [JsonSerializable(typeof(RetrieveHostedNumberOrderData))]

    [JsonSerializable(typeof(UploadFileHostedNumberOrderRequest))]
    [JsonSerializable(typeof(UploadFileHostedNumberOrderResponse))]
    [JsonSerializable(typeof(UploadFileHostedNumberOrderData))]

    [JsonSerializable(typeof(BaseAutoResponseSetting))]

    [JsonSerializable(typeof(ListAutoResponseSettingsRequest))]
    [JsonSerializable(typeof(ListAutoResponseSettingsResponse))]
    [JsonSerializable(typeof(AutoResponseSetting))]
    [JsonSerializable(typeof(AutoResponseSettingsMeta))]

    [JsonSerializable(typeof(CreateAutoResponseSettingRequest))]
    [JsonSerializable(typeof(CreateAutoResponseSettingResponse))]
    [JsonSerializable(typeof(CreateAutoResponseSetting))]

    [JsonSerializable(typeof(GetAutoResponseSettingRequest))]
    [JsonSerializable(typeof(GetAutoResponseSettingResponse))]
    [JsonSerializable(typeof(GetAutoResponseSetting))]

    [JsonSerializable(typeof(UpdateAutoResponseSettingRequest))]
    [JsonSerializable(typeof(UpdateAutoResponseSettingResponse))]
    [JsonSerializable(typeof(UpdateAutoResponseSetting))]

    [JsonSerializable(typeof(DeleteAutoResponseSettingRequest))]
    [JsonSerializable(typeof(DeleteAutoResponseSettingResponse))]

    [JsonSerializable(typeof(BaseVerificationRequestResponse))]

    [JsonSerializable(typeof(ListVerificationRequestsRequest))]
    [JsonSerializable(typeof(ListVerificationRequestsResponse))]
    [JsonSerializable(typeof(VerificationRequestRecord))]
    [JsonSerializable(typeof(PhoneNumber))]
    [JsonSerializable(typeof(OptInWorkflowImage))]

    [JsonSerializable(typeof(SubmitVerificationRequestRequest))]
    [JsonSerializable(typeof(SubmitVerificationRequestResponse))]

    [JsonSerializable(typeof(GetVerificationRequestRequest))]
    [JsonSerializable(typeof(GetVerificationRequestResponse))]

    [JsonSerializable(typeof(DeleteVerificationRequestRequest))]
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

    [JsonSerializable(typeof(GetBrandRequest))]
    [JsonSerializable(typeof(GetBrandResponse))]

    [JsonSerializable(typeof(UpdateBrandRequest))]
    [JsonSerializable(typeof(UpdateBrandResponse))]

    [JsonSerializable(typeof(DeleteBrandRequest))]
    [JsonSerializable(typeof(DeleteBrandResponse))]

    [JsonSerializable(typeof(ResendBrand2FAEmailRequest))]
    [JsonSerializable(typeof(ResendBrand2FAEmailResponse))]

    [JsonSerializable(typeof(RevetBrandRequest))]
    [JsonSerializable(typeof(RevetBrandResponse))]

    [JsonSerializable(typeof(ListExternalVettingRequest))]
    [JsonSerializable(typeof(ListExternalVettingResponse))]

    [JsonSerializable(typeof(ImportExternalVettingRequest))]
    [JsonSerializable(typeof(ImportExternalVettingResponse))]

    [JsonSerializable(typeof(OrderExternalVettingRequest))]
    [JsonSerializable(typeof(OrderExternalVettingResponse))]

    [JsonSerializable(typeof(GetBrandFeedbackRequest))]
    [JsonSerializable(typeof(GetBrandFeedbackResponse))]
    [JsonSerializable(typeof(Category))]

    [JsonSerializable(typeof(ListCampaignsRequest))]
    [JsonSerializable(typeof(ListCampaignsResponse))]
    [JsonSerializable(typeof(CampaignRecord))]

    [JsonSerializable(typeof(GetCampaignRequest))]
    [JsonSerializable(typeof(GetCampaignResponse))]

    [JsonSerializable(typeof(UpdateCampaignRequest))]
    [JsonSerializable(typeof(UpdateCampaignResponse))]

    [JsonSerializable(typeof(DeactivateCampaignRequest))]
    [JsonSerializable(typeof(DeactivateCampaignResponse))]

    [JsonSerializable(typeof(GetCampaignOperationStatusRequest))]
    [JsonSerializable(typeof(GetCampaignOperationStatusResponse))]

    [JsonSerializable(typeof(GetCampaignOsrAttributesRequest))]
    [JsonSerializable(typeof(GetCampaignOsrAttributesResponse))]

    [JsonSerializable(typeof(GetCampaignCostRequest))]
    [JsonSerializable(typeof(GetCampaignCostResponse))]

    [JsonSerializable(typeof(SubmitCampaignRequest))]
    [JsonSerializable(typeof(SubmitCampaignResponse))]

    [JsonSerializable(typeof(QualifyCampaignByUsecaseRequest))]
    [JsonSerializable(typeof(QualifyCampaignByUsecaseResponse))]

    [JsonSerializable(typeof(AcceptSharedCampaignRequest))]
    [JsonSerializable(typeof(AcceptSharedCampaignResponse))]

    [JsonSerializable(typeof(GetCampaignMnoMetadataRequest))]
    [JsonSerializable(typeof(GetCampaignMnoMetadataResponse))]
    [JsonSerializable(typeof(MnoMetadataDetail))]

    [JsonSerializable(typeof(GetCampaignSharingStatusResponse))]
    [JsonSerializable(typeof(GetCampaignSharingStatusRequest))]
    [JsonSerializable(typeof(SharingStatusDetail))]

    [JsonSerializable(typeof(RetrievePhoneNumberCampaignsRequest))]
    [JsonSerializable(typeof(RetrievePhoneNumberCampaignsResponse))]
    [JsonSerializable(typeof(RetrievePhoneNumberCampaign))]

    [JsonSerializable(typeof(CreatePhoneNumberCampaignRequest))]
    [JsonSerializable(typeof(CreatePhoneNumberCampaignResponse))]

    [JsonSerializable(typeof(GetPhoneNumberCampaignRequest))]
    [JsonSerializable(typeof(GetPhoneNumberCampaignResponse))]

    [JsonSerializable(typeof(UpdatePhoneNumberCampaignRequest))]
    [JsonSerializable(typeof(UpdatePhoneNumberCampaignResponse))]

    [JsonSerializable(typeof(DeletePhoneNumberCampaignRequest))]
    [JsonSerializable(typeof(DeletePhoneNumberCampaignResponse))]

    [JsonSerializable(typeof(AssignMessagingProfileToCampaignRequest))]
    [JsonSerializable(typeof(AssignMessagingProfileToCampaignResponse))]

    [JsonSerializable(typeof(GetPhoneNumberStatusResponse))]
    [JsonSerializable(typeof(PhoneNumberStatusRecord))]
    [JsonSerializable(typeof(GetPhoneNumberStatusRequest))]

    [JsonSerializable(typeof(GetAssignmentTaskStatusResponse))]
    [JsonSerializable(typeof(GetAssignmentTaskStatusRequest))]

    [JsonSerializable(typeof(BaseSharedCampaigns))]

    [JsonSerializable(typeof(ListSharedCampaignsRequest))]
    [JsonSerializable(typeof(ListSharedCampaignsResponse))]
    [JsonSerializable(typeof(SharedCampaignRecord))]

    [JsonSerializable(typeof(GetSharedCampaignRecordResponse))]
    [JsonSerializable(typeof(GetSharedCampaignRecordRequest))]

    [JsonSerializable(typeof(UpdateSingleSharedCampaignRequest))]
    [JsonSerializable(typeof(UpdateSingleSharedCampaignResponse))]

    [JsonSerializable(typeof(GetSharingStatusRequest))]
    [JsonSerializable(typeof(GetSharingStatusResponse))]

    [JsonSerializable(typeof(GetPartnerCampaignsSharedByUserRequest))]
    [JsonSerializable(typeof(GetPartnerCampaignsSharedByUserResponse))]
    [JsonSerializable(typeof(PartnerCampaignsSharedByUser))]

    [JsonSerializable(typeof(GetEnumRequest))]
    [JsonSerializable(typeof(GetEnumResponse))]


    //Enums
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
    [JsonSerializable(typeof(DeliveryUpdateMessageProfile))]
    [JsonSerializable(typeof(DeliveryUpdateMessageProfileData))]
    [JsonSerializable(typeof(DeliveryUpdateMessageProfilePayload))]

    [JsonSerializable(typeof(ReplacedLinkClick))]

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
    // [JsonSerializable(typeof(StreamingFailedEvent))]
    // [JsonSerializable(typeof(StreamingStartedEvent))]
    // [JsonSerializable(typeof(StreamingStoppedEvent))]
    // [JsonSerializable(typeof(VideoRoomCompositionCompletedEvent))]
    // [JsonSerializable(typeof(VideoRoomRecordingStartedEvent))]
    // [JsonSerializable(typeof(VideoRoomSessionEndedEvent))]
    // [JsonSerializable(typeof(VideoRoomSessionStartedEvent))]
    [JsonSourceGenerationOptions(
        UseStringEnumConverter = true,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
    public partial class TelnyxJsonSerializerContext : JsonSerializerContext
    {

    }
}
