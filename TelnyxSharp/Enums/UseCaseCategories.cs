using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
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
        [JsonStringEnumMemberName("2FA")]
        TwoFactorAuthentication,

        /// <summary>
        /// App notifications, such as updates or alerts.
        /// </summary>
        [JsonStringEnumMemberName("App Notifications")]
        AppNotifications,

        /// <summary>
        /// Appointment-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("Appointments")]
        Appointments,

        /// <summary>
        /// Auction notifications.
        /// </summary>
        [JsonStringEnumMemberName("Auctions")]
        Auctions,

        /// <summary>
        /// Auto repair service-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("Auto Repair Services")]
        AutoRepairServices,

        /// <summary>
        /// Bank transfer notifications.
        /// </summary>
        [JsonStringEnumMemberName("Bank Transfers")]
        BankTransfers,

        /// <summary>
        /// Billing-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("Billing")]
        Billing,

        /// <summary>
        /// Booking confirmation notifications.
        /// </summary>
        [JsonStringEnumMemberName("Booking Confirmations")]
        BookingConfirmations,

        /// <summary>
        /// Business updates such as news or offers.
        /// </summary>
        [JsonStringEnumMemberName("Business Updates")]
        BusinessUpdates,

        /// <summary>
        /// COVID-19 alerts and notifications.
        /// </summary>
        [JsonStringEnumMemberName("COVID-19 Alerts")]
        Covid19Alerts,

        /// <summary>
        /// Career training notifications.
        /// </summary>
        [JsonStringEnumMemberName("Career Training")]
        CareerTraining,

        /// <summary>
        /// Chatbot notifications.
        /// </summary>
        [JsonStringEnumMemberName("Chatbot")]
        Chatbot,

        /// <summary>
        /// Conversational messages and alerts.
        /// </summary>
        [JsonStringEnumMemberName("Conversational / Alerts")]
        ConversationalAlerts,

        /// <summary>
        /// Courier services and delivery notifications.
        /// </summary>
        [JsonStringEnumMemberName("Courier Services & Deliveries")]
        CourierServicesAndDeliveries,

        /// <summary>
        /// Emergency alert notifications.
        /// </summary>
        [JsonStringEnumMemberName("Emergency Alerts")]
        EmergencyAlerts,

        /// <summary>
        /// Events and planning-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("Events & Planning")]
        EventsAndPlanning,

        /// <summary>
        /// Financial services notifications.
        /// </summary>
        [JsonStringEnumMemberName("Financial Services")]
        FinancialServices,

        /// <summary>
        /// Fraud alert notifications.
        /// </summary>
        [JsonStringEnumMemberName("Fraud Alerts")]
        FraudAlerts,

        /// <summary>
        /// Fundraising-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("Fundraising")]
        Fundraising,

        /// <summary>
        /// General marketing messages.
        /// </summary>
        [JsonStringEnumMemberName("General Marketing")]
        GeneralMarketing,

        /// <summary>
        /// General school updates notifications.
        /// </summary>
        [JsonStringEnumMemberName("General School Updates")]
        GeneralSchoolUpdates,

        /// <summary>
        /// HR and staffing-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("HR / Staffing")]
        HRStaffing,

        /// <summary>
        /// Healthcare alert notifications.
        /// </summary>
        [JsonStringEnumMemberName("Healthcare Alerts")]
        HealthcareAlerts,

        /// <summary>
        /// Housing and community update notifications.
        /// </summary>
        [JsonStringEnumMemberName("Housing Community Updates")]
        HousingCommunityUpdates,

        /// <summary>
        /// Insurance service notifications.
        /// </summary>
        [JsonStringEnumMemberName("Insurance Services")]
        InsuranceServices,

        /// <summary>
        /// Job dispatch notifications.
        /// </summary>
        [JsonStringEnumMemberName("Job Dispatch")]
        JobDispatch,

        /// <summary>
        /// Legal service-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("Legal Services")]
        LegalServices,

        /// <summary>
        /// Mixed or undefined use case.
        /// </summary>
        [JsonStringEnumMemberName("Mixed")]
        Mixed,

        /// <summary>
        /// Motivational reminders and messages.
        /// </summary>
        [JsonStringEnumMemberName("Motivational Reminders")]
        MotivationalReminders,

        /// <summary>
        /// Notary notification messages.
        /// </summary>
        [JsonStringEnumMemberName("Notary Notifications")]
        NotaryNotifications,

        /// <summary>
        /// Order-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("Order Notifications")]
        OrderNotifications,

        /// <summary>
        /// Political notifications or updates.
        /// </summary>
        [JsonStringEnumMemberName("Political")]
        Political,

        /// <summary>
        /// Public works-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("Public Works")]
        PublicWorks,

        /// <summary>
        /// Real estate service notifications.
        /// </summary>
        [JsonStringEnumMemberName("Real Estate Services")]
        RealEstateServices,

        /// <summary>
        /// Religious service-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("Religious Services")]
        ReligiousServices,

        /// <summary>
        /// Repair and diagnostic alert notifications.
        /// </summary>
        [JsonStringEnumMemberName("Repair and Diagnostics Alerts")]
        RepairAndDiagnosticsAlerts,

        /// <summary>
        /// Rewards program-related notifications.
        /// </summary>
        [JsonStringEnumMemberName("Rewards Program")]
        RewardsProgram,

        /// <summary>
        /// Survey notifications.
        /// </summary>
        [JsonStringEnumMemberName("Surveys")]
        Surveys,

        /// <summary>
        /// System alert notifications.
        /// </summary>
        [JsonStringEnumMemberName("System Alerts")]
        SystemAlerts,

        /// <summary>
        /// Voting reminder notifications.
        /// </summary>
        [JsonStringEnumMemberName("Voting Reminders")]
        VotingReminders,

        /// <summary>
        /// Waitlist alert notifications.
        /// </summary>
        [JsonStringEnumMemberName("Waitlist Alerts")]
        WaitlistAlerts,

        /// <summary>
        /// Webinar reminder notifications.
        /// </summary>
        [JsonStringEnumMemberName("Webinar Reminders")]
        WebinarReminders,

        /// <summary>
        /// Workshop alert notifications.
        /// </summary>
        [JsonStringEnumMemberName("Workshop Alerts")]
        WorkshopAlerts
    }
}