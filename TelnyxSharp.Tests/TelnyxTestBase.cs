using Xunit;

namespace TelnyxSharp.Tests
{
    public abstract class TelnyxTestBase : IDisposable
    {
        protected readonly TelnyxClient Client;
        protected readonly bool IsIntegrationTest;
        protected readonly string TestPrefix;
        protected readonly bool DebugMode;
        protected readonly string DebugLogPath;

        protected TelnyxTestBase()
        {
            // Enable debug mode via environment variable or always for integration tests
            DebugMode = Environment.GetEnvironmentVariable("TELNYX_DEBUG")?.ToLower() == "true" || 
                       Environment.GetEnvironmentVariable("TELNYX_TEST_DEBUG")?.ToLower() == "true";
            
            // Set debug log path for tests
            DebugLogPath = Path.Combine(Path.GetTempPath(), "TelnyxTests", "Logs");

            IsIntegrationTest = SharedTelnyxClient.IsIntegrationTestEnabled;

            if (IsIntegrationTest)
            {
                // Use the shared client instance for all integration tests
                Client = SharedTelnyxClient.Instance;
                TestPrefix = $"TEST_{DateTime.UtcNow:yyyyMMddHHmmss}_";
                
                Console.WriteLine($"[TEST] Debug logs will be written to: {DebugLogPath}");
            }
            else
            {
                // For unit tests, we'll use mock values (create separate instance)
                Client = new TelnyxClient("mock_api_key", "mock_user", "mock_token", debugMode: DebugMode, debugLogPath: DebugLogPath);
                TestPrefix = "MOCK_TEST_";
            }
        }

        protected void SkipIfNotIntegrationTest()
        {
            if (!IsIntegrationTest)
            {
                return; // Skip test - integration tests require TELNYX_API_KEY environment variable
            }
        }

        public virtual void Dispose()
        {
            // Don't dispose the shared client - it's managed by SharedTelnyxClient
            if (!IsIntegrationTest)
            {
                Client?.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
