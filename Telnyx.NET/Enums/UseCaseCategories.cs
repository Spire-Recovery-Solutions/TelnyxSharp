using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing various use case categories for messaging.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UseCaseCategories
    {
        /// <summary>
        /// Unknown use case category.
        /// </summary>
        Unknown,

        /// <summary>
        /// Two-factor authentication (2FA) messages.
        /// </summary>
        [JsonPropertyName("2FA")]
        TwoFactorAuthentication,

        /// <summary>
        /// App notifications, such as updates or alerts.
        /// </summary>
        [JsonPropertyName("App Notifications")]
        AppNotifications,

        /// <summary>
        /// Appointment-related notifications.
        /// </summary>
        [JsonPropertyName("Appointments")]
        Appointments,

        /// <summary>
        /// Auction notifications.
        /// </summary>
        [JsonPropertyName("Auctions")]
        Auctions,

        /// <summary>
        /// Auto repair service-related notifications.
        /// </summary>
        [JsonPropertyName("Auto Repair Services")]
        AutoRepairServices,

        /// <summary>
        /// Bank transfer notifications.
        /// </summary>
        [JsonPropertyName("Bank Transfers")]
        BankTransfers,

        /// <summary>
        /// Billing-related notifications.
        /// </summary>
        [JsonPropertyName("Billing")]
        Billing,

        /// <summary>
        /// Booking confirmation notifications.
        /// </summary>
        [JsonPropertyName("Booking Confirmations")]
        BookingConfirmations,

        /// <summary>
        /// Business updates such as news or offers.
        /// </summary>
        [JsonPropertyName("Business Updates")]
        BusinessUpdates,

        /// <summary>
        /// COVID-19 alerts and notifications.
        /// </summary>
        [JsonPropertyName("COVID-19 Alerts")]
        Covid19Alerts,

        /// <summary>
        /// Career training notifications.
        /// </summary>
        [JsonPropertyName("Career Training")]
        CareerTraining,

        /// <summary>
        /// Chatbot notifications.
        /// </summary>
        [JsonPropertyName("Chatbot")]
        Chatbot,

        /// <summary>
        /// Conversational messages and alerts.
        /// </summary>
        [JsonPropertyName("Conversational / Alerts")]
        ConversationalAlerts,

        /// <summary>
        /// Courier services and delivery notifications.
        /// </summary>
        [JsonPropertyName("Courier Services & Deliveries")]
        CourierServicesAndDeliveries,

        /// <summary>
        /// Emergency alert notifications.
        /// </summary>
        [JsonPropertyName("Emergency Alerts")]
        EmergencyAlerts,

        /// <summary>
        /// Events and planning-related notifications.
        /// </summary>
        [JsonPropertyName("Events & Planning")]
        EventsAndPlanning,

        /// <summary>
        /// Financial services notifications.
        /// </summary>
        [JsonPropertyName("Financial Services")]
        FinancialServices,

        /// <summary>
        /// Fraud alert notifications.
        /// </summary>
        [JsonPropertyName("Fraud Alerts")]
        FraudAlerts,

        /// <summary>
        /// Fundraising-related notifications.
        /// </summary>
        [JsonPropertyName("Fundraising")]
        Fundraising,

        /// <summary>
        /// General marketing messages.
        /// </summary>
        [JsonPropertyName("General Marketing")]
        GeneralMarketing,

        /// <summary>
        /// General school updates notifications.
        /// </summary>
        [JsonPropertyName("General School Updates")]
        GeneralSchoolUpdates,

        /// <summary>
        /// HR and staffing-related notifications.
        /// </summary>
        [JsonPropertyName("HR / Staffing")]
        HRStaffing,

        /// <summary>
        /// Healthcare alert notifications.
        /// </summary>
        [JsonPropertyName("Healthcare Alerts")]
        HealthcareAlerts,

        /// <summary>
        /// Housing and community update notifications.
        /// </summary>
        [JsonPropertyName("Housing Community Updates")]
        HousingCommunityUpdates,

        /// <summary>
        /// Insurance service notifications.
        /// </summary>
        [JsonPropertyName("Insurance Services")]
        InsuranceServices,

        /// <summary>
        /// Job dispatch notifications.
        /// </summary>
        [JsonPropertyName("Job Dispatch")]
        JobDispatch,

        /// <summary>
        /// Legal service-related notifications.
        /// </summary>
        [JsonPropertyName("Legal Services")]
        LegalServices,

        /// <summary>
        /// Mixed or undefined use case.
        /// </summary>
        [JsonPropertyName("Mixed")]
        Mixed,

        /// <summary>
        /// Motivational reminders and messages.
        /// </summary>
        [JsonPropertyName("Motivational Reminders")]
        MotivationalReminders,

        /// <summary>
        /// Notary notification messages.
        /// </summary>
        [JsonPropertyName("Notary Notifications")]
        NotaryNotifications,

        /// <summary>
        /// Order-related notifications.
        /// </summary>
        [JsonPropertyName("Order Notifications")]
        OrderNotifications,

        /// <summary>
        /// Political notifications or updates.
        /// </summary>
        [JsonPropertyName("Political")]
        Political,

        /// <summary>
        /// Public works-related notifications.
        /// </summary>
        [JsonPropertyName("Public Works")]
        PublicWorks,

        /// <summary>
        /// Real estate service notifications.
        /// </summary>
        [JsonPropertyName("Real Estate Services")]
        RealEstateServices,

        /// <summary>
        /// Religious service-related notifications.
        /// </summary>
        [JsonPropertyName("Religious Services")]
        ReligiousServices,

        /// <summary>
        /// Repair and diagnostic alert notifications.
        /// </summary>
        [JsonPropertyName("Repair and Diagnostics Alerts")]
        RepairAndDiagnosticsAlerts,

        /// <summary>
        /// Rewards program-related notifications.
        /// </summary>
        [JsonPropertyName("Rewards Program")]
        RewardsProgram,

        /// <summary>
        /// Survey notifications.
        /// </summary>
        [JsonPropertyName("Surveys")]
        Surveys,

        /// <summary>
        /// System alert notifications.
        /// </summary>
        [JsonPropertyName("System Alerts")]
        SystemAlerts,

        /// <summary>
        /// Voting reminder notifications.
        /// </summary>
        [JsonPropertyName("Voting Reminders")]
        VotingReminders,

        /// <summary>
        /// Waitlist alert notifications.
        /// </summary>
        [JsonPropertyName("Waitlist Alerts")]
        WaitlistAlerts,

        /// <summary>
        /// Webinar reminder notifications.
        /// </summary>
        [JsonPropertyName("Webinar Reminders")]
        WebinarReminders,

        /// <summary>
        /// Workshop alert notifications.
        /// </summary>
        [JsonPropertyName("Workshop Alerts")]
        WorkshopAlerts
    }
}