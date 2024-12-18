using Telnyx.NET.Models;
using System.Text.Json.Serialization;

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
    [JsonSerializable(typeof(Data))]
    [JsonSerializable(typeof(Cost))]
    [JsonSerializable(typeof(From))]
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

    [JsonSerializable(typeof(MessagingProfilesRequest))]
    [JsonSerializable(typeof(MessagingProfilesResponse))]
    [JsonSerializable(typeof(MessagingProfile))]
    [JsonSerializable(typeof(UrlShortenerSettings))]
    [JsonSerializable(typeof(MessagingProfilesMeta))]

    [JsonSourceGenerationOptions(
        UseStringEnumConverter = true,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
    public partial class TelnyxJsonSerializerContext : JsonSerializerContext
    {

    }
}
