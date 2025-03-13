using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="UseCaseCategories"/> enum.
    /// </summary>
    public class UseCaseCategoriesConverter : JsonConverter<UseCaseCategories>
    {
        public override UseCaseCategories Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "Unknown" => UseCaseCategories.Unknown,
                "2FA" => UseCaseCategories.TwoFactorAuthentication,
                "App Notifications" => UseCaseCategories.AppNotifications,
                "Appointments" => UseCaseCategories.Appointments,
                "Auctions" => UseCaseCategories.Auctions,
                "Auto Repair Services" => UseCaseCategories.AutoRepairServices,
                "Bank Transfers" => UseCaseCategories.BankTransfers,
                "Billing" => UseCaseCategories.Billing,
                "Booking Confirmations" => UseCaseCategories.BookingConfirmations,
                "Business Updates" => UseCaseCategories.BusinessUpdates,
                "COVID-19 Alerts" => UseCaseCategories.Covid19Alerts,
                "Career Training" => UseCaseCategories.CareerTraining,
                "Chatbot" => UseCaseCategories.Chatbot,
                "Conversational / Alerts" => UseCaseCategories.ConversationalAlerts,
                "Courier Services & Deliveries" => UseCaseCategories.CourierServicesAndDeliveries,
                "Emergency Alerts" => UseCaseCategories.EmergencyAlerts,
                "Events & Planning" => UseCaseCategories.EventsAndPlanning,
                "Financial Services" => UseCaseCategories.FinancialServices,
                "Fraud Alerts" => UseCaseCategories.FraudAlerts,
                "Fundraising" => UseCaseCategories.Fundraising,
                "General Marketing" => UseCaseCategories.GeneralMarketing,
                "General School Updates" => UseCaseCategories.GeneralSchoolUpdates,
                "HR / Staffing" => UseCaseCategories.HRStaffing,
                "Healthcare Alerts" => UseCaseCategories.HealthcareAlerts,
                "Housing Community Updates" => UseCaseCategories.HousingCommunityUpdates,
                "Insurance Services" => UseCaseCategories.InsuranceServices,
                "Job Dispatch" => UseCaseCategories.JobDispatch,
                "Legal Services" => UseCaseCategories.LegalServices,
                "Mixed" => UseCaseCategories.Mixed,
                "Motivational Reminders" => UseCaseCategories.MotivationalReminders,
                "Notary Notifications" => UseCaseCategories.NotaryNotifications,
                "Order Notifications" => UseCaseCategories.OrderNotifications,
                "Political" => UseCaseCategories.Political,
                "Public Works" => UseCaseCategories.PublicWorks,
                "Real Estate Services" => UseCaseCategories.RealEstateServices,
                "Religious Services" => UseCaseCategories.ReligiousServices,
                "Repair and Diagnostics Alerts" => UseCaseCategories.RepairAndDiagnosticsAlerts,
                "Rewards Program" => UseCaseCategories.RewardsProgram,
                "Surveys" => UseCaseCategories.Surveys,
                "System Alerts" => UseCaseCategories.SystemAlerts,
                "Voting Reminders" => UseCaseCategories.VotingReminders,
                "Waitlist Alerts" => UseCaseCategories.WaitlistAlerts,
                "Webinar Reminders" => UseCaseCategories.WebinarReminders,
                "Workshop Alerts" => UseCaseCategories.WorkshopAlerts,
                _ => throw new JsonException($"Value '{value}' is not supported for UseCaseCategories enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, UseCaseCategories value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                UseCaseCategories.Unknown => "Unknown",
                UseCaseCategories.TwoFactorAuthentication => "2FA",
                UseCaseCategories.AppNotifications => "App Notifications",
                UseCaseCategories.Appointments => "Appointments",
                UseCaseCategories.Auctions => "Auctions",
                UseCaseCategories.AutoRepairServices => "Auto Repair Services",
                UseCaseCategories.BankTransfers => "Bank Transfers",
                UseCaseCategories.Billing => "Billing",
                UseCaseCategories.BookingConfirmations => "Booking Confirmations",
                UseCaseCategories.BusinessUpdates => "Business Updates",
                UseCaseCategories.Covid19Alerts => "COVID-19 Alerts",
                UseCaseCategories.CareerTraining => "Career Training",
                UseCaseCategories.Chatbot => "Chatbot",
                UseCaseCategories.ConversationalAlerts => "Conversational / Alerts",
                UseCaseCategories.CourierServicesAndDeliveries => "Courier Services & Deliveries",
                UseCaseCategories.EmergencyAlerts => "Emergency Alerts",
                UseCaseCategories.EventsAndPlanning => "Events & Planning",
                UseCaseCategories.FinancialServices => "Financial Services",
                UseCaseCategories.FraudAlerts => "Fraud Alerts",
                UseCaseCategories.Fundraising => "Fundraising",
                UseCaseCategories.GeneralMarketing => "General Marketing",
                UseCaseCategories.GeneralSchoolUpdates => "General School Updates",
                UseCaseCategories.HRStaffing => "HR / Staffing",
                UseCaseCategories.HealthcareAlerts => "Healthcare Alerts",
                UseCaseCategories.HousingCommunityUpdates => "Housing Community Updates",
                UseCaseCategories.InsuranceServices => "Insurance Services",
                UseCaseCategories.JobDispatch => "Job Dispatch",
                UseCaseCategories.LegalServices => "Legal Services",
                UseCaseCategories.Mixed => "Mixed",
                UseCaseCategories.MotivationalReminders => "Motivational Reminders",
                UseCaseCategories.NotaryNotifications => "Notary Notifications",
                UseCaseCategories.OrderNotifications => "Order Notifications",
                UseCaseCategories.Political => "Political",
                UseCaseCategories.PublicWorks => "Public Works",
                UseCaseCategories.RealEstateServices => "Real Estate Services",
                UseCaseCategories.ReligiousServices => "Religious Services",
                UseCaseCategories.RepairAndDiagnosticsAlerts => "Repair and Diagnostics Alerts",
                UseCaseCategories.RewardsProgram => "Rewards Program",
                UseCaseCategories.Surveys => "Surveys",
                UseCaseCategories.SystemAlerts => "System Alerts",
                UseCaseCategories.VotingReminders => "Voting Reminders",
                UseCaseCategories.WaitlistAlerts => "Waitlist Alerts",
                UseCaseCategories.WebinarReminders => "Webinar Reminders",
                UseCaseCategories.WorkshopAlerts => "Workshop Alerts",
                _ => throw new JsonException($"Value '{value}' is not supported for UseCaseCategories enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
