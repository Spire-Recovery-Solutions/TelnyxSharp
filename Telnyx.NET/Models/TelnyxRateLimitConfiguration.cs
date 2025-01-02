namespace Telnyx.NET.Models
{
    public sealed class TelnyxRateLimitConfiguration
    {
        public int Global { get; set; } = 40;
        public int NumberSearch { get; set; } = 40;
        public int PhoneNumbers { get; set; } = 60;
        public int Connections { get; set; } = 5;
        public int FQDNConnections { get; set; } = 5;
        public int IPConnections { get; set; } = 5;
        public int CredentialsConnections { get; set; } = 5;
        public int CallControlApplications { get; set; } = 5;
        public int TeXMLApplications { get; set; } = 5;
        public int FaxApplications { get; set; } = 5;
        public int OutboundVoiceProfiles { get; set; } = 5;
        public int MessagingProfiles { get; set; } = 5;
        public int NumberOrders { get; set; } = 1;
        public int SendMessage { get; set; } = 1;
        public int PortNumbers { get; set; } = 1;
        public int NumberReservations { get; set; } = 1;
        public int NumberLookups { get; set; } = 1;
        public int Calls { get; set; } = 100;

    }
}
