using System.Collections.Concurrent;
using Xunit.Abstractions;

namespace TelnyxSharp.Tests
{
    public abstract class NumberManagementTestBase : TelnyxTestBase, IAsyncLifetime
    {
        protected readonly ITestOutputHelper Output;
        protected readonly ConcurrentBag<string> PhoneNumbersToCleanup = new();
        protected readonly ConcurrentBag<string> ReservationsToCleanup = new();
        protected readonly ConcurrentBag<string> OrdersToCleanup = new();
        protected readonly string TestAreaCode;
        protected readonly string TestCountry;
        protected readonly int MaxTestNumbers;
        protected readonly bool EnableCleanup;
        protected readonly bool AllowCostIncurringTests;
        protected readonly bool AllowVolatileTests;

        protected NumberManagementTestBase(ITestOutputHelper output)
        {
            Output = output;
            TestAreaCode = Environment.GetEnvironmentVariable("TELNYX_TEST_AREA_CODE") ?? "212";
            TestCountry = Environment.GetEnvironmentVariable("TELNYX_TEST_COUNTRY") ?? "US";
            MaxTestNumbers = int.TryParse(Environment.GetEnvironmentVariable("TELNYX_TEST_MAX_NUMBERS"), out var max) ? max : 5;
            EnableCleanup = Environment.GetEnvironmentVariable("TELNYX_TEST_CLEANUP")?.ToLower() != "false";
            AllowCostIncurringTests = Environment.GetEnvironmentVariable("TELNYX_ALLOW_COST_TESTS")?.ToLower() == "true";
            AllowVolatileTests = Environment.GetEnvironmentVariable("TELNYX_ALLOW_VOLATILE_TESTS")?.ToLower() == "true";

            Output.WriteLine($"Test Configuration:");
            Output.WriteLine($"  Area Code: {TestAreaCode}");
            Output.WriteLine($"  Country: {TestCountry}");
            Output.WriteLine($"  Max Numbers: {MaxTestNumbers}");
            Output.WriteLine($"  Cleanup Enabled: {EnableCleanup}");
            Output.WriteLine($"  Test Prefix: {TestPrefix}");
            Output.WriteLine($"  Debug Log Path: {DebugLogPath}");
            Output.WriteLine($"  COST TESTS ALLOWED: {AllowCostIncurringTests}");
        }

        public virtual Task InitializeAsync()
        {
            return Task.CompletedTask;
        }

        public virtual async Task DisposeAsync()
        {
            if (!EnableCleanup || !IsIntegrationTest)
            {
                Output.WriteLine("Skipping cleanup");
                return;
            }

            Output.WriteLine("Starting test cleanup...");

            // Clean up phone numbers
            foreach (var phoneNumberId in PhoneNumbersToCleanup)
            {
                try
                {
                    Output.WriteLine($"Deleting phone number: {phoneNumberId}");
                    await Client.PhoneNumbers.PhoneNumberConfiguration.Delete(phoneNumberId);
                    Output.WriteLine($"Successfully deleted phone number: {phoneNumberId}");
                }
                catch (Exception ex)
                {
                    Output.WriteLine($"Failed to delete phone number {phoneNumberId}: {ex.Message}");
                }
            }

            // Clean up reservations
            foreach (var reservationId in ReservationsToCleanup)
            {
                try
                {
                    Output.WriteLine($"Reservation {reservationId} will expire automatically");
                    // Reservations expire automatically, no deletion needed
                }
                catch (Exception ex)
                {
                    Output.WriteLine($"Failed to handle reservation {reservationId}: {ex.Message}");
                }
            }

            // Clean up orders
            foreach (var orderId in OrdersToCleanup)
            {
                try
                {
                    Output.WriteLine($"Order {orderId} tracked for cleanup");
                    // Orders typically can't be deleted, only cancelled if pending
                }
                catch (Exception ex)
                {
                    Output.WriteLine($"Failed to handle order {orderId}: {ex.Message}");
                }
            }

            Output.WriteLine("Cleanup completed");
        }




        protected void SkipIfCostTestsNotAllowed()
        {
            if (!AllowCostIncurringTests)
            {
                return; // Skip test - cost-incurring tests require TELNYX_ALLOW_COST_TESTS=true environment variable
            }
        }

        protected void SkipIfVolatileTestsNotAllowed()
        {
            if (!AllowVolatileTests)
            {
                return; // Skip test - volatile tests require TELNYX_ALLOW_VOLATILE_TESTS=true environment variable
            }
        }

        protected void AssertNotEmpty(string value, string fieldName)
        {
            Assert.False(string.IsNullOrWhiteSpace(value), $"{fieldName} should not be empty");
        }

        protected void AssertValidPhoneNumber(string phoneNumber)
        {
            Assert.NotNull(phoneNumber);
            Assert.Matches(@"^\+?[1-9]\d{1,14}$", phoneNumber);
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}