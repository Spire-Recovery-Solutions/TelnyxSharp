namespace TelnyxSharp.Tests
{
    public abstract class TelnyxTestBase : IDisposable
    {
        protected readonly TelnyxClient Client;

        protected TelnyxTestBase()
        {
            var apiKey = "TELNYX_API_KEY"
                ?? throw new InvalidOperationException("TELNYX_API_KEY environment variable not set");

            var v1ApiToken = "TELNYX_V1_API_TOKEN"
                ?? throw new InvalidOperationException("TELNYX_V1_API_TOKEN environment variable not set");

            Client = new TelnyxClient(apiKey, v1ApiToken);
        }

        public void Dispose()
        {
            Client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
