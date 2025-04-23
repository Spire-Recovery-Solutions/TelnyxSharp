namespace TelnyxSharp.Tests
{
    public abstract class TelnyxTestBase : IDisposable
    {
        protected readonly TelnyxClient Client;

        protected TelnyxTestBase()
        {
            var apiKey = "set me"
                          ?? throw new InvalidOperationException("TELNYX_API_KEY not set");
            var v1ApiUser = "set me";
            var v1ApiToken = "set me"
                             ?? throw new InvalidOperationException("TELNYX_V1_API_TOKEN not set");

            Client = new TelnyxClient(apiKey, v1ApiUser, v1ApiToken);
        }

        public void Dispose()
        {
            Client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
