using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing various use case categories for messaging.
    /// </summary>
    [JsonConverter(typeof(Converters.UseCaseCategoriesConverter))]
    public enum UseCaseCategories
    {
        /// <summary>
        /// Unknown use case category.
        /// </summary>
        Unknown,

        /// <summary>
        /// Two-factor authentication (2FA) messages.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("2FA")]
        TwoFactorAuthentication,

        /// <summary>
        /// App notifications, such as updates or alerts.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("App Notifications")]
        AppNotifications,

        /// <summary>
        /// Appointment-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Appointments")]
        Appointments,

        /// <summary>
        /// Auction notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Auctions")]
        Auctions,

        /// <summary>
        /// Auto repair service-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Auto Repair Services")]
        AutoRepairServices,

        /// <summary>
        /// Bank transfer notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Bank Transfers")]
        BankTransfers,

        /// <summary>
        /// Billing-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Billing")]
        Billing,

        /// <summary>
        /// Booking confirmation notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Booking Confirmations")]
        BookingConfirmations,

        /// <summary>
        /// Business updates such as news or offers.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Business Updates")]
        BusinessUpdates,

        /// <summary>
        /// COVID-19 alerts and notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("COVID-19 Alerts")]
        Covid19Alerts,

        /// <summary>
        /// Career training notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Career Training")]
        CareerTraining,

        /// <summary>
        /// Chatbot notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Chatbot")]
        Chatbot,

        /// <summary>
        /// Conversational messages and alerts.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Conversational / Alerts")]
        ConversationalAlerts,

        /// <summary>
        /// Courier services and delivery notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Courier Services & Deliveries")]
        CourierServicesAndDeliveries,

        /// <summary>
        /// Emergency alert notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Emergency Alerts")]
        EmergencyAlerts,

        /// <summary>
        /// Events and planning-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Events & Planning")]
        EventsAndPlanning,

        /// <summary>
        /// Financial services notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Financial Services")]
        FinancialServices,

        /// <summary>
        /// Fraud alert notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Fraud Alerts")]
        FraudAlerts,

        /// <summary>
        /// Fundraising-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Fundraising")]
        Fundraising,

        /// <summary>
        /// General marketing messages.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("General Marketing")]
        GeneralMarketing,

        /// <summary>
        /// General school updates notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("General School Updates")]
        GeneralSchoolUpdates,

        /// <summary>
        /// HR and staffing-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("HR / Staffing")]
        HRStaffing,

        /// <summary>
        /// Healthcare alert notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Healthcare Alerts")]
        HealthcareAlerts,

        /// <summary>
        /// Housing and community update notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Housing Community Updates")]
        HousingCommunityUpdates,

        /// <summary>
        /// Insurance service notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Insurance Services")]
        InsuranceServices,

        /// <summary>
        /// Job dispatch notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Job Dispatch")]
        JobDispatch,

        /// <summary>
        /// Legal service-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Legal Services")]
        LegalServices,

        /// <summary>
        /// Mixed or undefined use case.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Mixed")]
        Mixed,

        /// <summary>
        /// Motivational reminders and messages.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Motivational Reminders")]
        MotivationalReminders,

        /// <summary>
        /// Notary notification messages.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Notary Notifications")]
        NotaryNotifications,

        /// <summary>
        /// Order-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Order Notifications")]
        OrderNotifications,

        /// <summary>
        /// Political notifications or updates.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Political")]
        Political,

        /// <summary>
        /// Public works-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Public Works")]
        PublicWorks,

        /// <summary>
        /// Real estate service notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Real Estate Services")]
        RealEstateServices,

        /// <summary>
        /// Religious service-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Religious Services")]
        ReligiousServices,

        /// <summary>
        /// Repair and diagnostic alert notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Repair and Diagnostics Alerts")]
        RepairAndDiagnosticsAlerts,

        /// <summary>
        /// Rewards program-related notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Rewards Program")]
        RewardsProgram,

        /// <summary>
        /// Survey notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Surveys")]
        Surveys,

        /// <summary>
        /// System alert notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("System Alerts")]
        SystemAlerts,

        /// <summary>
        /// Voting reminder notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Voting Reminders")]
        VotingReminders,

        /// <summary>
        /// Waitlist alert notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Waitlist Alerts")]
        WaitlistAlerts,

        /// <summary>
        /// Webinar reminder notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Webinar Reminders")]
        WebinarReminders,

        /// <summary>
        /// Workshop alert notifications.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Workshop Alerts")]
        WorkshopAlerts
    }
}