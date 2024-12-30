using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UseCaseCategories
    {
        Unknown,

        [JsonPropertyName("2FA")]
        TwoFactorAuthentication,

        [JsonPropertyName("App Notifications")]
        AppNotifications,

        [JsonPropertyName("Appointments")]
        Appointments,

        [JsonPropertyName("Auctions")]
        Auctions,

        [JsonPropertyName("Auto Repair Services")]
        AutoRepairServices,

        [JsonPropertyName("Bank Transfers")]
        BankTransfers,

        [JsonPropertyName("Billing")]
        Billing,

        [JsonPropertyName("Booking Confirmations")]
        BookingConfirmations,

        [JsonPropertyName("Business Updates")]
        BusinessUpdates,

        [JsonPropertyName("COVID-19 Alerts")]
        Covid19Alerts,

        [JsonPropertyName("Career Training")]
        CareerTraining,

        [JsonPropertyName("Chatbot")]
        Chatbot,

        [JsonPropertyName("Conversational / Alerts")]
        ConversationalAlerts,

        [JsonPropertyName("Courier Services & Deliveries")]
        CourierServicesAndDeliveries,

        [JsonPropertyName("Emergency Alerts")]
        EmergencyAlerts,

        [JsonPropertyName("Events & Planning")]
        EventsAndPlanning,

        [JsonPropertyName("Financial Services")]
        FinancialServices,

        [JsonPropertyName("Fraud Alerts")]
        FraudAlerts,

        [JsonPropertyName("Fundraising")]
        Fundraising,

        [JsonPropertyName("General Marketing")]
        GeneralMarketing,

        [JsonPropertyName("General School Updates")]
        GeneralSchoolUpdates,

        [JsonPropertyName("HR / Staffing")]
        HRStaffing,

        [JsonPropertyName("Healthcare Alerts")]
        HealthcareAlerts,

        [JsonPropertyName("Housing Community Updates")]
        HousingCommunityUpdates,

        [JsonPropertyName("Insurance Services")]
        InsuranceServices,

        [JsonPropertyName("Job Dispatch")]
        JobDispatch,

        [JsonPropertyName("Legal Services")]
        LegalServices,

        [JsonPropertyName("Mixed")]
        Mixed,

        [JsonPropertyName("Motivational Reminders")]
        MotivationalReminders,

        [JsonPropertyName("Notary Notifications")]
        NotaryNotifications,

        [JsonPropertyName("Order Notifications")]
        OrderNotifications,

        [JsonPropertyName("Political")]
        Political,

        [JsonPropertyName("Public Works")]
        PublicWorks,

        [JsonPropertyName("Real Estate Services")]
        RealEstateServices,

        [JsonPropertyName("Religious Services")]
        ReligiousServices,

        [JsonPropertyName("Repair and Diagnostics Alerts")]
        RepairAndDiagnosticsAlerts,

        [JsonPropertyName("Rewards Program")]
        RewardsProgram,

        [JsonPropertyName("Surveys")]
        Surveys,

        [JsonPropertyName("System Alerts")]
        SystemAlerts,

        [JsonPropertyName("Voting Reminders")]
        VotingReminders,

        [JsonPropertyName("Waitlist Alerts")]
        WaitlistAlerts,

        [JsonPropertyName("Webinar Reminders")]
        WebinarReminders,

        [JsonPropertyName("Workshop Alerts")]
        WorkshopAlerts
    }
}