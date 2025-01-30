using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;
using Telnyx.NET.Identity.Models.NumberLookup.Requests;
using Telnyx.NET.Identity.Models.NumberLookup.Responses;
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
using Telnyx.NET.Numbers.Models.ChannelZones.Requests;
using Telnyx.NET.Numbers.Models.ChannelZones.Responses;
using Telnyx.NET.Numbers.Models.Documents.Requests;
using Telnyx.NET.Numbers.Models.InboundChannels.Requests;
using Telnyx.NET.Numbers.Models.InboundChannels.Responses;
using Telnyx.NET.Numbers.Models.NumberPortout.Requests;
using Telnyx.NET.Numbers.Models.NumberPortout.Responses;
using Telnyx.NET.Numbers.Models.PhoneNumbers;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.AdvancedNumberOrders;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.BulkPhoneNumberOperations;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.CsvDownloads;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.Documents;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.InventoryLevel;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.NumbersFeatures;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlockOrders;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlocksBackgroundJobs;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberPorting;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberReservations;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberSearch;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.RegulatoryRequirements;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.RequirementGroups;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.Requirements;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.RequirementTypes;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.AdvancedNumberOrders;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.BulkPhoneNumberOperations;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CountryCoverage;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CsvDowloads;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CsvDownloads;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.Documents;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.InventoryLevel;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.NumbersFeatures;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlockOrders;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlocksBackgroundJobs;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberPorting;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberReservartions;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberSearch;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RegulatoryRequirements;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RequirementGroups;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.Requirements;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RequirementTypes;
using Telnyx.NET.Numbers.Models.Voicemail.Requests;
using Telnyx.NET.Numbers.Models.Voicemail.Responses;
using Telnyx.NET.Voice.Events;
using Telnyx.NET.Voice.Models.CallCommands.Requests;
using Telnyx.NET.Voice.Models.CallCommands.Responses;
using Telnyx.NET.Voice.Models.CallControlApplications;
using Telnyx.NET.Voice.Models.CallControlApplications.Requests;
using Telnyx.NET.Voice.Models.CallControlApplications.Responses;
using Telnyx.NET.Voice.Models.CallInformation.Requests;
using Telnyx.NET.Voice.Models.CallInformation.Responses;
using Telnyx.NET.Voice.Models.ConferenceCommands;
using Telnyx.NET.Voice.Models.ConferenceCommands.Requests;
using Telnyx.NET.Voice.Models.ConferenceCommands.Responses;
using Telnyx.NET.Voice.Models.Debugging.Requests;
using Telnyx.NET.Voice.Models.Debugging.Responses;
using Telnyx.NET.Voice.Models.QueueCommands.Requests;
using Telnyx.NET.Voice.Models.QueueCommands.Responses;

namespace Telnyx.NET
{
    [JsonSerializable(typeof(AvailablePhoneNumbersResponse))]
    [JsonSerializable(typeof(AvailablePhoneNumbersDatum))]
    [JsonSerializable(typeof(CostInformation))]
    [JsonSerializable(typeof(Feature))]
    [JsonSerializable(typeof(RegionInformation))]
    [JsonSerializable(typeof(AvailablePhoneNumbersMeta))]
    [JsonSerializable(typeof(AvailablePhoneNumbersRequest))]
    [JsonSerializable(typeof(NumberOrderRegulatoryRequirement))]
    [JsonSerializable(typeof(BaseNumberOrdersData))]
    [JsonSerializable(typeof(PhoneNumbersJobPhoneNumber))]
    [JsonSerializable(typeof(CreateNumberOrderRequest))]
    [JsonSerializable(typeof(CreateNumberOrderPhoneNumber))]
    [JsonSerializable(typeof(CreateNumberOrderResponse))]
    [JsonSerializable(typeof(CreateNumberOrderData))]
    [JsonSerializable(typeof(PhoneNumberOrderData))]
    [JsonSerializable(typeof(CreateNumberReservationRequest))]
    [JsonSerializable(typeof(CreateNumberReservationPhoneNumber))]
    [JsonSerializable(typeof(CreateNumberReservationResponse))]
    [JsonSerializable(typeof(NumberReservationData))]
    [JsonSerializable(typeof(ReservedPhoneNumber))]
    [JsonSerializable(typeof(GetNumberOrderResponse))]
    [JsonSerializable(typeof(GetNumberOrderData))]
    [JsonSerializable(typeof(ListNumberOrdersResponse))]
    [JsonSerializable(typeof(NumberOrdersPhoneNumber))]
    [JsonSerializable(typeof(ListNumberOrdersRequest))]
    [JsonSerializable(typeof(ListNumbersRequest))]
    [JsonSerializable(typeof(ListNumbersResponse))]
    [JsonSerializable(typeof(NumberConfigurationData))]
    [JsonSerializable(typeof(ListPortingOrdersRequest))]
    [JsonSerializable(typeof(PortingOrdersRequest))]
    [JsonSerializable(typeof(ListPortingOrdersResponse))]
    [JsonSerializable(typeof(ListPortingOrdersDatum))]
    [JsonSerializable(typeof(PortingOrdersActivationSettings))]
    [JsonSerializable(typeof(PortingOrdersDocuments))]
    [JsonSerializable(typeof(PortingOrdersEndUser))]
    [JsonSerializable(typeof(PortingOrdersAdmin))]
    [JsonSerializable(typeof(PortingOrdersLocation))]
    [JsonSerializable(typeof(PortingOrdersMisc))]
    [JsonSerializable(typeof(PortingOrdersPhoneNumberConfiguration))]
    [JsonSerializable(typeof(PortingOrdersPhoneNumber))]
    [JsonSerializable(typeof(PortingOrdersStatus))]
    [JsonSerializable(typeof(PortingOrdersDetail))]
    [JsonSerializable(typeof(PortingOrdersUserFeedback))]

    [JsonSerializable(typeof(ListPortingPhoneNumbersRequest))]
    [JsonSerializable(typeof(ListPortingPhoneNumbersResponse))]


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

    [JsonSerializable(typeof(PhoneNumberVoiceSettings))]
    [JsonSerializable(typeof(CallForwardingSettings))]
    [JsonSerializable(typeof(CnamListingSettings))]
    [JsonSerializable(typeof(EmergencySettings))]
    [JsonSerializable(typeof(MediaFeatures))]
    [JsonSerializable(typeof(CallRecordingSettings))]

    [JsonSerializable(typeof(UpdateNumberConfigurationRequest))]
    [JsonSerializable(typeof(UpdateNumberConfigurationResponse))]
    [JsonSerializable(typeof(UpdateNumberVoiceSettingsRequest))]
    [JsonSerializable(typeof(UpdateNumberVoiceSettingsResponse))]

    [JsonSerializable(typeof(CallCommandsResponse))]
    [JsonSerializable(typeof(CallCommandsResponseData))]

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

    [JsonSerializable(typeof(AnswerCallRequest))]


    [JsonSerializable(typeof(HangupCallRequest))]

    [JsonSerializable(typeof(RejectCallRequest))]

    [JsonSerializable(typeof(SpeakTextRequest))]

    [JsonSerializable(typeof(PlaybackStartRequest))]

    [JsonSerializable(typeof(StopAudioPlaybackRequest))]

    [JsonSerializable(typeof(EnqueueCallRequest))]

    [JsonSerializable(typeof(RemoveCallFromQueueRequest))]

    [JsonSerializable(typeof(TransferCallRequest))]

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

    [JsonSerializable(typeof(BridgeCallRequest))]

    [JsonSerializable(typeof(ForkMediaRequest))]

    [JsonSerializable(typeof(ForkStopRequest))]

    [JsonSerializable(typeof(GatherRequest))]

    [JsonSerializable(typeof(GatherUsingAudioRequest))]

    [JsonSerializable(typeof(GatherUsingAiRequest))]
    [JsonSerializable(typeof(Transcription))]
    [JsonSerializable(typeof(VoiceSettings))]
    [JsonSerializable(typeof(TelnyxVoiceSettings))]
    [JsonSerializable(typeof(ElevenLabsVoiceSettings))]
    [JsonSerializable(typeof(AWSVoiceSettings))]
    [JsonSerializable(typeof(AssistantConfig))]
    [JsonSerializable(typeof(MessageHistory))]
    [JsonSerializable(typeof(InterruptionSettings))]

    [JsonSerializable(typeof(GatherStopRequest))]

    [JsonSerializable(typeof(AiAssistantStartRequest))]

    [JsonSerializable(typeof(AiAssistantStopRequest))]

    [JsonSerializable(typeof(UpdateClientStateRequest))]

    [JsonSerializable(typeof(SipReferRequest))]

    [JsonSerializable(typeof(RecordingStartRequest))]
    [JsonSerializable(typeof(TranscriptionLanguageConfig))]
    [JsonSerializable(typeof(GoogleTranscriptionLanguageConfig))]

    [JsonSerializable(typeof(RecordPauseRequest))]

    [JsonSerializable(typeof(RecordResumeRequest))]

    [JsonSerializable(typeof(RecordStopRequest))]

    [JsonSerializable(typeof(SendDtmfRequest))]

    [JsonSerializable(typeof(SendDtmfRequest))]

    [JsonSerializable(typeof(SendSipInfoRequest))]

    [JsonSerializable(typeof(SiprecStartRequest))]

    [JsonSerializable(typeof(SiprecStopRequest))]

    [JsonSerializable(typeof(StreamingStartRequest))]

    [JsonSerializable(typeof(StreamingStopRequest))]

    [JsonSerializable(typeof(NoiseSuppressionStartRequest))]

    [JsonSerializable(typeof(NoiseSuppressionStopRequest))]

    [JsonSerializable(typeof(TranscriptionStopRequest))]

    [JsonSerializable(typeof(BaseConferenceData))]

    [JsonSerializable(typeof(CreateConferenceResponse))]
    [JsonSerializable(typeof(EndedBy))]
    [JsonSerializable(typeof(CreateConferenceRequest))]

    [JsonSerializable(typeof(ListConferencesRequest))]
    [JsonSerializable(typeof(ListConferencesResponse))]

    [JsonSerializable(typeof(RetrieveConferenceResponse))]
    [JsonSerializable(typeof(RetrieveConferenceData))]

    [JsonSerializable(typeof(ListConferenceParticipantsResponse))]
    [JsonSerializable(typeof(ListConferenceParticipantsData))]
    [JsonSerializable(typeof(ListConferenceParticipantsRequest))]

    [JsonSerializable(typeof(JoinConferenceRequest))]
    [JsonSerializable(typeof(ConferenceCommandResponse))]
    [JsonSerializable(typeof(ConferenceCommandData))]

    [JsonSerializable(typeof(LeaveConferenceRequest))]

    [JsonSerializable(typeof(UpdateConferenceRequest))]

    [JsonSerializable(typeof(MuteConferenceParticipantsRequest))]

    [JsonSerializable(typeof(UnmuteConferenceParticipantsRequest))]

    [JsonSerializable(typeof(HoldConferenceParticipantsRequest))]

    [JsonSerializable(typeof(UnholdConferenceParticipantsRequest))]

    [JsonSerializable(typeof(StartConferenceRecordingRequest))]

    [JsonSerializable(typeof(StopConferenceRecordingRequest))]

    [JsonSerializable(typeof(PauseConferenceRecordingRequest))]

    [JsonSerializable(typeof(ResumeConferenceRecordingRequest))]

    [JsonSerializable(typeof(SpeakTextToConferenceRequest))]

    [JsonSerializable(typeof(PlayAudioToConferenceRequest))]
    [JsonSerializable(typeof(Loop))]
    [JsonSerializable(typeof(MOD1))]
    [JsonSerializable(typeof(MOD2))]

    [JsonSerializable(typeof(StopAudioToConferenceRequest))]

    [JsonSerializable(typeof(ListCallEventsRequest))]
    [JsonSerializable(typeof(ListCallEventsResponse))]
    [JsonSerializable(typeof(ListCallEventsData))]

    [JsonSerializable(typeof(ListCallControlApplicationsRequest))]
    [JsonSerializable(typeof(ListCallControlApplicationsResponse))]
    [JsonSerializable(typeof(ListCallControlApplicationsData))]

    [JsonSerializable(typeof(BaseCallControlApplications))]
    [JsonSerializable(typeof(InboundSettings))]
    [JsonSerializable(typeof(OutboundSettings))]

    [JsonSerializable(typeof(CreateCallControlApplicationRequest))]
    [JsonSerializable(typeof(CreateCallControlApplicationResponse))]
    [JsonSerializable(typeof(CreateCallControlApplicationData))]

    [JsonSerializable(typeof(RetrieveCallControlApplicationResponse))]
    [JsonSerializable(typeof(RetrieveCallControlApplicationData))]

    [JsonSerializable(typeof(UpdateCallControlApplicationRequest))]
    [JsonSerializable(typeof(UpdateCallControlApplicationResponse))]
    [JsonSerializable(typeof(UpdateCallControlApplicationData))]

    [JsonSerializable(typeof(DeleteCallControlApplicationResponse))]
    [JsonSerializable(typeof(DeleteCallControlApplicationData))]

    [JsonSerializable(typeof(RetrieveQueueResponse))]
    [JsonSerializable(typeof(RetrieveQueueResponseData))]

    [JsonSerializable(typeof(RetrieveCallQueueResponse))]
    [JsonSerializable(typeof(RetrieveCallQueueData))]

    [JsonSerializable(typeof(RetrieveCallsQueueRequest))]
    [JsonSerializable(typeof(RetrieveCallsQueueResponse))]
    [JsonSerializable(typeof(RetrieveCallsQueueData))]

    [JsonSerializable(typeof(ListActiveCallsRequest))]
    [JsonSerializable(typeof(ListActiveCallsResponse))]
    [JsonSerializable(typeof(ListActiveCallsData))]
    [JsonSerializable(typeof(ActiveCallsMetaCursors))]
    [JsonSerializable(typeof(ActiveCallsMeta))]

    [JsonSerializable(typeof(DeletePhoneNumberResponse))]
    [JsonSerializable(typeof(DeletePhoneNumberData))]

    [JsonSerializable(typeof(ListAvailablePhoneNumberBlocksRequest))]
    [JsonSerializable(typeof(ListAvailablePhoneNumberBlocksResponse))]
    [JsonSerializable(typeof(ListAvailablePhoneNumberBlocksData))]

    [JsonSerializable(typeof(GetNumberReservationResponse))]

    [JsonSerializable(typeof(ExtendNumberReservationResponse))]

    [JsonSerializable(typeof(UpdateNumberOrderRequest))]
    [JsonSerializable(typeof(UpdateNumberOrderRegulatoryRequirement))]
    [JsonSerializable(typeof(UpdateNumberOrderResponse))]
    [JsonSerializable(typeof(UpdateNumberOrderData))]

    [JsonSerializable(typeof(ListSubNumberOrdersRequest))]
    [JsonSerializable(typeof(ListSubNumberOrdersResponse))]
    [JsonSerializable(typeof(SubNumberOrderData))]

    [JsonSerializable(typeof(GetSubNumberOrderRequest))]
    [JsonSerializable(typeof(GetSubNumberOrderResponse))]

    [JsonSerializable(typeof(UpdateSubNumberOrderRequest))]
    [JsonSerializable(typeof(UpdateSubNumberOrderResponse))]

    [JsonSerializable(typeof(CancelNumberOrderResponse))]

    [JsonSerializable(typeof(ListNumberOrderPhonesResponse))]
    [JsonSerializable(typeof(NumberOrderPhonesData))]
    [JsonSerializable(typeof(ListNumberOrderPhonesRequest))]

    [JsonSerializable(typeof(SingleNumberOrderPhoneResponse))]

    [JsonSerializable(typeof(UpdateNumberOrderPhoneRequest))]
    [JsonSerializable(typeof(UpdateNumberOrderPhoneResponse))]

    [JsonSerializable(typeof(CreateCommentRequest))]
    [JsonSerializable(typeof(CreateCommentResponse))]
    [JsonSerializable(typeof(CommentData))]

    [JsonSerializable(typeof(ListCommentsRequest))]
    [JsonSerializable(typeof(ListCommentsResponse))]

    [JsonSerializable(typeof(MarkCommentReadResponse))]

    [JsonSerializable(typeof(SlimListNumbersRequest))]
    [JsonSerializable(typeof(SlimListNumbersResponse))]
    [JsonSerializable(typeof(SlimListNumbersData))]

    [JsonSerializable(typeof(GetNumberResponse))]

    [JsonSerializable(typeof(ListNumbersWithVoiceSettingsResponse))]
    [JsonSerializable(typeof(ListNumbersWithVoiceSettingsRequest))]

    [JsonSerializable(typeof(GetNumberVoiceSettingsResponse))]

    [JsonSerializable(typeof(EnableEmergencyRequest))]
    [JsonSerializable(typeof(EnableEmergencyResponse))]

    [JsonSerializable(typeof(ChangeBundleStatusRequest))]
    [JsonSerializable(typeof(ChangeBundleStatusResponse))]

    [JsonSerializable(typeof(ListNumbersJobsRequest))]
    [JsonSerializable(typeof(ListNumbersJobsResponse))]
    [JsonSerializable(typeof(NumbersJobsData))]
    [JsonSerializable(typeof(PhoneNumbersFailedJobNumber))]

    [JsonSerializable(typeof(RetrieveNumbersJobResponse))]

    [JsonSerializable(typeof(UpdateNumbersBatchRequest))]
    [JsonSerializable(typeof(UpdateNumbersBatchResponse))]
    [JsonSerializable(typeof(BatchVoiceSettings))]

    [JsonSerializable(typeof(DeleteNumbersBatchRequest))]
    [JsonSerializable(typeof(DeleteNumbersBatchResponse))]

    [JsonSerializable(typeof(UpdateEmergencySettingsRequest))]
    [JsonSerializable(typeof(UpdateEmergencySettingsResponse))]

    [JsonSerializable(typeof(InventoryCoverageRequest))]
    [JsonSerializable(typeof(InventoryCoverageResponse))]
    [JsonSerializable(typeof(InventoryCoverageData))]

    [JsonSerializable(typeof(ListPhoneNumberBlockJobsRequest))]
    [JsonSerializable(typeof(ListPhoneNumberBlockJobsResponse))]
    [JsonSerializable(typeof(PhoneNumberBlockJobData))]

    [JsonSerializable(typeof(GetPhoneNumberBlocksJobResponse))]

    [JsonSerializable(typeof(DeletePhoneNumberBlockRequest))]
    [JsonSerializable(typeof(DeletePhoneNumberBlockResponse))]

    [JsonSerializable(typeof(GetRegulatoryRequirementsRequest))]
    [JsonSerializable(typeof(GetRegulatoryRequirementsResponse))]
    [JsonSerializable(typeof(RegulatoryRequirement))]
    [JsonSerializable(typeof(RequirementDetail))]
    [JsonSerializable(typeof(AcceptanceCriteria))]

    [JsonSerializable(typeof(ListRegulatoryRequirementsRequest))]
    [JsonSerializable(typeof(ListRegulatoryRequirementsResponse))]
    [JsonSerializable(typeof(ListRegulatoryRequirementsData))]

    [JsonSerializable(typeof(UpdateSubNumberOrderRequirementRequest))]
    [JsonSerializable(typeof(UpdateSubNumberOrderRequirementResponse))]
    [JsonSerializable(typeof(UpdateSubNumberOrderRequirementData))]

    [JsonSerializable(typeof(UpdatePhoneNumberOrderRequirementRequest))]
    [JsonSerializable(typeof(UpdatePhoneNumberOrderRequirementResponse))]
    [JsonSerializable(typeof(PhoneNumberOrderRequirementData))]
    [JsonSerializable(typeof(PhoneNumberRegRequirement))]

    [JsonSerializable(typeof(ListRequirementGroupsRequest))]
    [JsonSerializable(typeof(ListRequirementGroupsResponse))]
    [JsonSerializable(typeof(RegulatoryRequirementDetail))]
    [JsonSerializable(typeof(RequirementGroupData))]

    [JsonSerializable(typeof(CreateRequirementGroupRequest))]
    [JsonSerializable(typeof(CreateRequirementGroupResponse))]

    [JsonSerializable(typeof(GetRequirementGroupResponse))]

    [JsonSerializable(typeof(DeleteRequirementGroupResponse))]

    [JsonSerializable(typeof(UpdateRequirementGroupRequest))]
    [JsonSerializable(typeof(UpdateRequirementGroupResponse))]

    [JsonSerializable(typeof(SubmitRequirementGroupApprovalResponse))]

    [JsonSerializable(typeof(ListCountryCoverageResponse))]
    [JsonSerializable(typeof(CountryCoverageDetails))]

    [JsonSerializable(typeof(GetCountryCoverageResponse))]

    [JsonSerializable(typeof(ListNumberBlockOrdersRequest))]
    [JsonSerializable(typeof(ListNumberBlockOrdersResponse))]
    [JsonSerializable(typeof(NumberBlockOrder))]

    [JsonSerializable(typeof(CreateNumberBlockOrderRequest))]
    [JsonSerializable(typeof(CreateNumberBlockOrderResponse))]

    [JsonSerializable(typeof(GetNumberBlockOrderResponse))]

    [JsonSerializable(typeof(CreateAdvancedOrderRequest))]
    [JsonSerializable(typeof(CreateAdvancedOrderResponse))]

    [JsonSerializable(typeof(ListAdvancedOrdersResponse))]

    [JsonSerializable(typeof(GetAdvancedOrderResponse))]

    [JsonSerializable(typeof(ListCsvDownloadsRequest))]
    [JsonSerializable(typeof(ListCsvDownloadsResponse))]
    [JsonSerializable(typeof(CsvDownload))]

    [JsonSerializable(typeof(CreateCsvDownloadResponse))]

    [JsonSerializable(typeof(GetCsvDownloadResponse))]

    [JsonSerializable(typeof(GetNumbersFeaturesRequest))]
    [JsonSerializable(typeof(GetNumbersFeaturesResponse))]
    [JsonSerializable(typeof(NumberFeature))]

    [JsonSerializable(typeof(GetVoicemailResponse))]
    [JsonSerializable(typeof(VoicemailSettings))]

    [JsonSerializable(typeof(CreateVoicemailRequest))]
    [JsonSerializable(typeof(CreateVoicemailResponse))]

    [JsonSerializable(typeof(UpdateVoicemailRequest))]
    [JsonSerializable(typeof(UpdateVoicemailResponse))]

    [JsonSerializable(typeof(ListChannelZonesRequest))]
    [JsonSerializable(typeof(ListChannelZonesResponse))]
    [JsonSerializable(typeof(ChannelZone))]

    [JsonSerializable(typeof(GetChannelZonesResponse))]

    [JsonSerializable(typeof(UpdateChannelZoneRequest))]
    [JsonSerializable(typeof(UpdateChannelZoneResponse))]

    [JsonSerializable(typeof(GetChannelZonePhoneNumbersRequest))]

    [JsonSerializable(typeof(GetChannelZonePhoneNumbersResponse))]
    [JsonSerializable(typeof(ChannelZonePhoneNumber))]

    [JsonSerializable(typeof(AssignPhoneNumberToChannelZoneResponse))]
    [JsonSerializable(typeof(AssignPhoneNumberToChannelZoneRequest))]

    [JsonSerializable(typeof(UnassignPhoneNumberResponse))]

    [JsonSerializable(typeof(ListInboundChannelsResponse))]
    [JsonSerializable(typeof(InboundChannels))]

    [JsonSerializable(typeof(UpdateInboundChannelsRequest))]
    [JsonSerializable(typeof(UpdateInboundChannelsResponse))]

    [JsonSerializable(typeof(ListPortoutRequest))]
    [JsonSerializable(typeof(ListPortoutResponse))]
    [JsonSerializable(typeof(PortoutData))]

    [JsonSerializable(typeof(GetPortoutResponse))]

    [JsonSerializable(typeof(UpdatePortoutStatusRequest))]
    [JsonSerializable(typeof(UpdatePortoutStatusResponse))]

    [JsonSerializable(typeof(PortoutCommentsResponse))]
    [JsonSerializable(typeof(PortoutComment))]

    [JsonSerializable(typeof(CreatePortoutCommentRequest))]
    [JsonSerializable(typeof(CreatePortoutCommentResponse))]

    [JsonSerializable(typeof(ListPortoutSupportingDocumentsResponse))]
    [JsonSerializable(typeof(PortoutSupportingDocument))]

    [JsonSerializable(typeof(CreatePortoutSupportingDocumentsRequest))]
    [JsonSerializable(typeof(SupportingDocumentDetail))]

    [JsonSerializable(typeof(CreatePortoutSupportingDocumentsResponse))]

    [JsonSerializable(typeof(ListPortoutReportsRequest))]
    [JsonSerializable(typeof(ListPortoutReportsResponse))]
    [JsonSerializable(typeof(PortoutReport))]
    [JsonSerializable(typeof(ExportPortoutsCSVReport))]
    [JsonSerializable(typeof(ExportFilters))]

    [JsonSerializable(typeof(CreatePortoutReportRequest))]
    [JsonSerializable(typeof(CreatePortoutReportResponse))]

    [JsonSerializable(typeof(GetPortoutReportResponse))]

    [JsonSerializable(typeof(ListPortoutRejectionCodesRequest))]
    [JsonSerializable(typeof(ListPortoutRejectionCodesResponse))]
    [JsonSerializable(typeof(PortoutRejectionCode))]

    [JsonSerializable(typeof(ListPortoutEventsRequest))]
    [JsonSerializable(typeof(ListPortoutEventsResponse))]
    [JsonSerializable(typeof(PortoutEvent))]

    [JsonSerializable(typeof(BasePortoutPayload))]
    [JsonSerializable(typeof(StatusChangedPayload))]
    [JsonSerializable(typeof(NewCommentPayload))]
    [JsonSerializable(typeof(FocDateChangedPayload))]

    [JsonSerializable(typeof(GetPortoutEventResponse))]
    [JsonSerializable(typeof(RepublishPortoutEventResponse))]

    [JsonSerializable(typeof(PortabilityCheckRequest))]
    [JsonSerializable(typeof(PortabilityCheckResponse))]
    [JsonSerializable(typeof(PortabilityCheckResult))]

    [JsonSerializable(typeof(ListDocumentsRequest))]
    [JsonSerializable(typeof(ListDocumentsResponse))]
    [JsonSerializable(typeof(Document))]

    [JsonSerializable(typeof(GetDocumentResponse))]

    [JsonSerializable(typeof(DeleteDocumentResponse))]

    [JsonSerializable(typeof(UpdateDocumentResponse))]
    [JsonSerializable(typeof(UpdateDocumentRequest))]

    [JsonSerializable(typeof(UploadDocumentRequest))]
    [JsonSerializable(typeof(UploadDocumentResponse))]
    [JsonSerializable(typeof(UpdateDocumentResponse))]

    [JsonSerializable(typeof(DownloadDocumentResponse))]

    [JsonSerializable(typeof(ListDocumentLinksRequest))]
    [JsonSerializable(typeof(ListDocumentLinksResponse))]
    [JsonSerializable(typeof(DocumentLink))]

    [JsonSerializable(typeof(ListRequirementsRequest))]
    [JsonSerializable(typeof(ListRequirementResponse))]
    [JsonSerializable(typeof(DocumentRequirement))]
    [JsonSerializable(typeof(RequirementType))]
    [JsonSerializable(typeof(RequirementAcceptanceCriteria))]

    [JsonSerializable(typeof(RetrieveDocumentRequirementResponse))]

    [JsonSerializable(typeof(ListRequirementTypesRequest))]
    [JsonSerializable(typeof(ListRequirementTypesResponse))]

    [JsonSerializable(typeof(RetrieveRequirementTypeResponse))]

    [JsonSerializable(typeof(CreatePortingOrderRequest))]
    [JsonSerializable(typeof(CreatePortingOrderResponse))]
    [JsonSerializable(typeof(PortingOrder))]
    [JsonSerializable(typeof(PortingRequirement))]
    [JsonSerializable(typeof(MessagingInfo))]

    [JsonSerializable(typeof(RetrievePortingOrderRequest))]
    [JsonSerializable(typeof(RetrievePortingOrderResponse))]

    [JsonSerializable(typeof(EditPortingOrderRequest))]
    [JsonSerializable(typeof(EditPortingOrderResponse))]

    [JsonSerializable(typeof(DeletePortingOrderResponse))]


    [JsonSerializable(typeof(DownloadLoaTemplateRequest))]
    [JsonSerializable(typeof(DownloadLoaTemplateResponse))]

    [JsonSerializable(typeof(GetSubRequestResponse))]
    [JsonSerializable(typeof(SubRequestData))]

    [JsonSerializable(typeof(CancelPortingOrderResponse))]

    [JsonSerializable(typeof(ConfirmPortingOrderResponse))]

    [JsonSerializable(typeof(SharePortingOrderRequest))]
    [JsonSerializable(typeof(SharePortingOrderResponse))]
    [JsonSerializable(typeof(PortingOrderSharingToken))]

    [JsonSerializable(typeof(ActivatePortingOrderResponse))]
    [JsonSerializable(typeof(PortingActivationJob))]

    [JsonSerializable(typeof(ListPortingActivationJobsRequest))]
    [JsonSerializable(typeof(ListPortingActivationJobsResponse))]

    [JsonSerializable(typeof(GetPortingActivationJobsResponse))]

    [JsonSerializable(typeof(UpdatePortingActivationJobRequest))]
    [JsonSerializable(typeof(UpdatePortingActivationJobResponse))]

    [JsonSerializable(typeof(CreatePortingCommentRequest))]
    [JsonSerializable(typeof(CreatePortingCommentResponse))]
    [JsonSerializable(typeof(PortingComment))]

    [JsonSerializable(typeof(ListPortingCommentsRequest))]
    [JsonSerializable(typeof(ListPortingCommentsResponse))]

    [JsonSerializable(typeof(ListAllowedFocWindowsResponse))]
    [JsonSerializable(typeof(FocWindow))]

    [JsonSerializable(typeof(ListPortingOrderRequirementsRequest))]
    [JsonSerializable(typeof(ListPortingOrderRequirementsResponse))]
    [JsonSerializable(typeof(ListPortingOrderRequirementsData))]
    [JsonSerializable(typeof(PortingRequirementType))]

    [JsonSerializable(typeof(ListPortingExceptionTypesResponse))]
    [JsonSerializable(typeof(ExceptionType))]

    [JsonSerializable(typeof(ListPhoneNumberConfigurationsRequest))]
    [JsonSerializable(typeof(ListPhoneNumberConfigurationsResponse))]

    [JsonSerializable(typeof(ListPortingPhoneNumbersRequest))]
    [JsonSerializable(typeof(ListPortingPhoneNumbersResponse))]

    [JsonSerializable(typeof(ListVerificationCodesResponse))]
    [JsonSerializable(typeof(VerificationCode))]

    [JsonSerializable(typeof(VerifyCodesRequest))]
    [JsonSerializable(typeof(VerificationCodeEntry))]
    [JsonSerializable(typeof(VerifyCodesResponse))]

    [JsonSerializable(typeof(SendVerificationCodesRequest))]
    [JsonSerializable(typeof(SendVerificationCodesResponse))]

    [JsonSerializable(typeof(ListAdditionalDocumentsRequest))]
    [JsonSerializable(typeof(ListAdditionalDocumentsResponse))]
    [JsonSerializable(typeof(AdditionalDocument))]

    [JsonSerializable(typeof(CreateAdditionalDocumentsRequest))]
    [JsonSerializable(typeof(AdditionalDocumentRequest))]
    [JsonSerializable(typeof(CreateAdditionalDocumentsResponse))]

    [JsonSerializable(typeof(DeleteAdditionalDocumentsResponse))]

    [JsonSerializable(typeof(ListPhoneNumberExtensionsRequest))]
    [JsonSerializable(typeof(ListPhoneNumberExtensionsResponse))]
    [JsonSerializable(typeof(PhoneNumberExtensionData))]
    [JsonSerializable(typeof(Ranges))]


    [JsonSerializable(typeof(CreatePhoneNumberExtensionsRequest))]
    [JsonSerializable(typeof(CreatePhoneNumberExtensionsResponse))]

    [JsonSerializable(typeof(DeletePhoneNumberExtensionsResponse))]

    [JsonSerializable(typeof(ListPortingPhoneBlocksRequest))]
    [JsonSerializable(typeof(ListPortingPhoneBlocksResponse))]
    [JsonSerializable(typeof(PortingPhoneBlock))]

    [JsonSerializable(typeof(CreatePortingPhoneBlockRequest))]
    [JsonSerializable(typeof(CreatePortingPhoneBlockResponse))]

    [JsonSerializable(typeof(DeletePortingPhoneBlockResponse))]

    [JsonSerializable(typeof(ListPortingReportsRequest))]
    [JsonSerializable(typeof(ListPortingReportsResponse))]
    [JsonSerializable(typeof(PortingReport))]
    [JsonSerializable(typeof(ReportParams))]
    [JsonSerializable(typeof(ReportFilters))]

    [JsonSerializable(typeof(GetPortingReportResponse))]

    [JsonSerializable(typeof(ListLoaConfigurationsRequest))]
    [JsonSerializable(typeof(ListLoaConfigurationsResponse))]
    [JsonSerializable(typeof(LoaConfiguration))]
    [JsonSerializable(typeof(LogoInfo))]
    [JsonSerializable(typeof(Address))]
    [JsonSerializable(typeof(Contact))]

    [JsonSerializable(typeof(CreateLoaConfigurationRequest))]
    [JsonSerializable(typeof(CreateLoaConfigurationResponse))]

    [JsonSerializable(typeof(PreviewLoaConfigurationParamRequest))]

    [JsonSerializable(typeof(GetLoaConfigurationResponse))]

    [JsonSerializable(typeof(UpdateLoaConfigurationRequest))]
    [JsonSerializable(typeof(UpdateLoaConfigurationResponse))]

    [JsonSerializable(typeof(UpdateLoaConfigurationRequest))]

    [JsonSerializable(typeof(DeleteLoaConfigurationResponse))]

    [JsonSerializable(typeof(PreviewLoaConfigurationResponse))]

    [JsonSerializable(typeof(ListPortingEventsRequest))]
    [JsonSerializable(typeof(ListPortingEventsResponse))]
    [JsonSerializable(typeof(PortingEvent))]
    [JsonSerializable(typeof(PortingEventPayload))]
    [JsonSerializable(typeof(PortingOrderDeletedPayload))]
    [JsonSerializable(typeof(PortingOrderMessagingChangedPayload))]
    [JsonSerializable(typeof(MessagingStatus))]
    [JsonSerializable(typeof(PortingOrderStatusChangedPayload))]
    [JsonSerializable(typeof(PortStatus))]
    [JsonSerializable(typeof(PortStatusDetail))]
    [JsonSerializable(typeof(PortingOrderNewCommentPayload))]
    [JsonSerializable(typeof(Comment))]
    [JsonSerializable(typeof(PortingOrderSplitPayload))]
    [JsonSerializable(typeof(PortingOrderNumberReference))]

    [JsonSerializable(typeof(GetPortingEventResponse))]

    [JsonSerializable(typeof(RepublishPortingEventsResponse))]

    //Enums
    [JsonSerializable(typeof(PortingOrderPermission))]
    [JsonSerializable(typeof(PortingOrderStatus))]
    [JsonSerializable(typeof(DocumentSort))]
    [JsonSerializable(typeof(RequirementSort))]
    [JsonSerializable(typeof(PortoutEventType))]
    [JsonSerializable(typeof(PortoutStatus))]
    [JsonSerializable(typeof(SupportingDocumentType))]
    [JsonSerializable(typeof(RequirementActionType))]
    [JsonSerializable(typeof(JobStatusType))]
    [JsonSerializable(typeof(CountryCode))]
    [JsonSerializable(typeof(FeatureType))]
    [JsonSerializable(typeof(GroupByType))]
    [JsonSerializable(typeof(PhoneNumberJobType))]
    [JsonSerializable(typeof(PhoneNumberStatusType))]
    [JsonSerializable(typeof(SortNumberConfiguration))]
    [JsonSerializable(typeof(VoiceUsagePaymentMethod))]
    [JsonSerializable(typeof(PhoneNumberType))]
    [JsonSerializable(typeof(RejectCallCause))]
    [JsonSerializable(typeof(DtmfType))]
    [JsonSerializable(typeof(AnchorsiteOverride))]
    [JsonSerializable(typeof(SipSubdomainReceiveSettings))]
    [JsonSerializable(typeof(EventType))]
    [JsonSerializable(typeof(ProductType))]
    [JsonSerializable(typeof(BeepEnabled))]
    [JsonSerializable(typeof(SupervisorRole))]
    [JsonSerializable(typeof(StreamBidirectionalMode))]
    [JsonSerializable(typeof(ConferenceStatus))]
    [JsonSerializable(typeof(StreamBidirectionalMode))]
    [JsonSerializable(typeof(StreamBidirectionalCodec))]
    [JsonSerializable(typeof(StreamBidirectionalTargetLegs))]
    [JsonSerializable(typeof(Track))]
    [JsonSerializable(typeof(GoogleLanguage))]
    [JsonSerializable(typeof(TelnyxLanguage))]
    [JsonSerializable(typeof(VoiceType))]
    [JsonSerializable(typeof(MessageRole))]
    [JsonSerializable(typeof(PayloadType))]
    [JsonSerializable(typeof(ServiceLevel))]
    [JsonSerializable(typeof(Language))]
    [JsonSerializable(typeof(StreamType))]
    [JsonSerializable(typeof(RecordTrack))]
    [JsonSerializable(typeof(RecordFormat))]
    [JsonSerializable(typeof(RecordChannels))]
    [JsonSerializable(typeof(RingtoneCountry))]
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


    [JsonSerializable(typeof(CallSipRecStartedEvent))]
    [JsonSerializable(typeof(SipRecStartedPayload))]
    [JsonSerializable(typeof(CallSipRecStoppedEvent))]
    [JsonSerializable(typeof(CallSipRecFailedEvent))]
    [JsonSerializable(typeof(SipRecFailedPayload))]

    [JsonSerializable(typeof(CallAiGatherEndedEvent))]
    [JsonSerializable(typeof(AiGatherEndedPayload))]
    [JsonSerializable(typeof(CallAiGatherPartialResultsEvent))]
    [JsonSerializable(typeof(AiGatherPartialResultsPayload))]

    [JsonSerializable(typeof(CallAnsweredEvent))]
    [JsonSerializable(typeof(CallAnsweredPayload))]
    [JsonSerializable(typeof(CallBridgedEvent))]
    [JsonSerializable(typeof(CallBridgedPayload))]
    // [JsonSerializable(typeof(CallDequeuedEvent))]
    [JsonSerializable(typeof(CallDtmfReceivedEvent))]
    [JsonSerializable(typeof(CallDtmfReceivedPayload))]
    [JsonSerializable(typeof(CallEnqueuedEvent))]
    [JsonSerializable(typeof(CallEnqueuedPayload))]
    [JsonSerializable(typeof(CallForkStartedEvent))]
    [JsonSerializable(typeof(CallForkStartedPayload))]
    [JsonSerializable(typeof(CallForkStoppedEvent))]
    [JsonSerializable(typeof(CallForkStoppedPayload))]
    [JsonSerializable(typeof(CallGatherEndedEvent))]
    [JsonSerializable(typeof(CallGatherEndedPayload))]
    [JsonSerializable(typeof(CallHangupEvent))]
    [JsonSerializable(typeof(CallHangupPayload))]
    [JsonSerializable(typeof(CallLeftQueueEvent))]
    [JsonSerializable(typeof(CallLeftQueuePayload))]
    [JsonSerializable(typeof(CallInitiatedEvent))]
    [JsonSerializable(typeof(CallInitiatedPayload))]
    [JsonSerializable(typeof(CallMachineDetectionEndedEvent))]
    [JsonSerializable(typeof(CallMachineDetectionEndedPayload))]
    [JsonSerializable(typeof(CallMachineGreetingEndedEvent))]
    [JsonSerializable(typeof(CallMachineGreetingEndedPayload))]
    [JsonSerializable(typeof(CallMachinePremiumDetectionEndedEvent))]
    [JsonSerializable(typeof(CallMachinePremiumDetectionEndedPayload))]
    [JsonSerializable(typeof(CallMachinePremiumGreetingEndedEvent))]
    [JsonSerializable(typeof(CallMachinePremiumGreetingEndedPayload))]
    [JsonSerializable(typeof(CallPlaybackEndedEvent))]
    [JsonSerializable(typeof(CallPlaybackEndedPayload))]
    [JsonSerializable(typeof(CallPlaybackStartedEvent))]
    [JsonSerializable(typeof(CallPlaybackStartedPayload))]
    [JsonSerializable(typeof(CallRecordingErrorEvent))]
    [JsonSerializable(typeof(CallRecordingErrorPayload))]
    [JsonSerializable(typeof(CallRecordingSavedEvent))]
    [JsonSerializable(typeof(CallRecordingSavedPayload))]
    [JsonSerializable(typeof(CallReferCompletedEvent))]
    [JsonSerializable(typeof(CallReferCompletedPayload))]
    [JsonSerializable(typeof(CallReferFailedEvent))]
    [JsonSerializable(typeof(CallReferFailedPayload))]
    [JsonSerializable(typeof(CallReferStartedEvent))]
    [JsonSerializable(typeof(CallReferStartedPayload))]
    [JsonSerializable(typeof(CallSpeakEndedEvent))]
    [JsonSerializable(typeof(CallSpeakEndedPayload))]
    [JsonSerializable(typeof(CallSpeakStartedEvent))]
    [JsonSerializable(typeof(CallSpeakStartedPayload))]
    [JsonSerializable(typeof(CallStreamingFailedEvent))]
    [JsonSerializable(typeof(CallStreamingFailedPayload))]
    [JsonSerializable(typeof(CallStreamingStartedEvent))]
    [JsonSerializable(typeof(CallStreamingStartedPayload))]
    [JsonSerializable(typeof(CallStreamingStoppedEvent))]
    [JsonSerializable(typeof(CallStreamingStoppedPayload))]
    // [JsonSerializable(typeof(CallTranscriptionEvent))]
    [JsonSerializable(typeof(ConferenceCreatedEvent))]
    [JsonSerializable(typeof(ConferenceCreatedPayload))]
    [JsonSerializable(typeof(ConferenceEndedEvent))]
    [JsonSerializable(typeof(ConferenceEndedPayload))]
    // [JsonSerializable(typeof(ConferenceFloorChangedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantJoinedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantJoinedPayload))]
    [JsonSerializable(typeof(ConferenceParticipantLeftEvent))]
    [JsonSerializable(typeof(ConferenceParticipantLeftPayload))]
    [JsonSerializable(typeof(ConferenceParticipantPlaybackEndedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantPlaybackEndedPayload))]
    [JsonSerializable(typeof(ConferenceParticipantPlaybackStartedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantPlaybackStartedPayload))]
    [JsonSerializable(typeof(ConferenceParticipantSpeakEndedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantSpeakEndedPayload))]
    [JsonSerializable(typeof(ConferenceParticipantSpeakStartedEvent))]
    [JsonSerializable(typeof(ConferenceParticipantSpeakStartedPayload))]
    [JsonSerializable(typeof(ConferencePlaybackEndedEvent))]
    [JsonSerializable(typeof(ConferencePlaybackEndedPayload))]
    [JsonSerializable(typeof(ConferencePlaybackStartedEvent))]
    [JsonSerializable(typeof(ConferencePlaybackStartedPayload))]
    [JsonSerializable(typeof(ConferenceRecordingSavedEvent))]
    [JsonSerializable(typeof(ConferenceRecordingSavedPayload))]
    [JsonSerializable(typeof(ConferenceSpeakEndedEvent))]
    [JsonSerializable(typeof(ConferenceSpeakEndedPayload))]
    [JsonSerializable(typeof(ConferenceSpeakStartedEvent))]
    [JsonSerializable(typeof(ConferenceSpeakStartedPayload))]
    [JsonSerializable(typeof(MessageReceivedEvent))]
    [JsonSerializable(typeof(MessageReceivedPayload))]
    [JsonSerializable(typeof(MessageSentEvent))]
    [JsonSerializable(typeof(MessageSentPayload))]
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
