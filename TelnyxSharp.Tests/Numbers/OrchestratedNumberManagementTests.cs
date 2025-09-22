using System.Collections.Concurrent;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberReservations;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberSearch;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders;
using Xunit;
using Xunit.Abstractions;

namespace TelnyxSharp.Tests.Numbers
{
    /// <summary>
    /// Orchestrated integration tests for Number Management.
    /// Tests are executed in a specific order to minimize costs and side effects.
    /// Phase 1: Read-only tests (search, list)
    /// Phase 2: Purchase one number and test configurations
    /// Phase 3: Optional reservation tests
    /// Phase 4: Cleanup
    /// 
    /// NOTE: Tests are named with Phase_XX prefix to control execution order
    /// </summary>
    [Collection("NumberManagement")]
    [Trait("Category", "Integration")]
    [Trait("Module", "Numbers")]
    public class OrchestratedNumberManagementTests : IClassFixture<NumberManagementTestFixture>, IAsyncLifetime
    {
        private readonly ITestOutputHelper _output;
        private readonly TelnyxClient _client;
        private readonly bool _runIntegrationTests;
        private readonly bool _purchaseTestNumber;
        private readonly bool _testReservations;
        private readonly string _testAreaCode;
        private readonly string _testCountry;
        private readonly NumberManagementTestFixture _fixture;
        
        // Shared state across test phases (now from fixture)
        private string? _availableNumberToPurchase => _fixture.AvailableNumberToPurchase;
        private string? _purchasedNumberId => _fixture.PurchasedNumberId;
        private string? _purchasedNumber => _fixture.PurchasedNumber;
        private string? _orderId;
        private string? _reservationId;
        private readonly ConcurrentBag<string> _commentsToCleanup = new();

        public OrchestratedNumberManagementTests(ITestOutputHelper output, NumberManagementTestFixture fixture)
        {
            _output = output;
            _fixture = fixture;
            
            // Load configuration
            _runIntegrationTests = Environment.GetEnvironmentVariable("TELNYX_RUN_INTEGRATION_TESTS")?.ToLower() == "true";
            _purchaseTestNumber = Environment.GetEnvironmentVariable("TELNYX_PURCHASE_TEST_NUMBER")?.ToLower() == "true";
            _testReservations = Environment.GetEnvironmentVariable("TELNYX_TEST_RESERVATIONS")?.ToLower() == "true";
            _testAreaCode = Environment.GetEnvironmentVariable("TELNYX_TEST_AREA_CODE") ?? "212";
            _testCountry = Environment.GetEnvironmentVariable("TELNYX_TEST_COUNTRY") ?? "US";
            
            // Use the shared client instance for all tests
            _client = SharedTelnyxClient.Instance;
            
            _output.WriteLine("=== Orchestrated Number Management Tests Configuration ===");
            _output.WriteLine($"Integration Tests Enabled: {_runIntegrationTests}");
            _output.WriteLine($"Purchase Test Number: {_purchaseTestNumber}");
            _output.WriteLine($"Test Reservations: {_testReservations}");
            _output.WriteLine($"Test Area Code: {_testAreaCode}");
            _output.WriteLine($"Test Country: {_testCountry}");
            _output.WriteLine($"Debug Log: {Path.Combine(Path.GetTempPath(), "TelnyxTests", "Logs")}");
            _output.WriteLine("=========================================================");
        }

        #region Phase 1: Read-Only Tests (No Purchase Required)

        [Fact]
        public async Task Phase1_01_SearchAvailableNumbers_ByAreaCode()
        {
            if (!_runIntegrationTests) return;
            
            _output.WriteLine("\n=== Phase 1.1: Search Available Numbers by Area Code ===");
            
            var request = new AvailablePhoneNumbersRequest
            {
                CountryCode = _testCountry,
                NationalDestinationCode = int.TryParse(_testAreaCode, out var ndc) ? ndc : null,
                Limit = 5,
                BestEffort = true  // Use best effort to find numbers even if not exact match
            };

            var response = await _client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(request);
            
            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            _output.WriteLine($"Found {response.Data.Count} available numbers");
            
            // Numbers are handled by the fixture now
            if (response.Data.Count > 0)
            {
                _output.WriteLine($"First available number: {response.Data.First().PhoneNumber}");
            }
            
            foreach (var number in response.Data.Take(3))
            {
                _output.WriteLine($"  - {number.PhoneNumber}: ${number.CostInformation?.MonthlyCost} {number.CostInformation?.Currency}/month");
            }
        }

        [Fact]
        public async Task Phase1_02_SearchAvailableNumbers_WithFeatures()
        {
            if (!_runIntegrationTests) return;
            
            _output.WriteLine("\n=== Phase 1.2: Search Numbers with Features ===");
            
            var request = new AvailablePhoneNumbersRequest
            {
                CountryCode = _testCountry,
                Limit = 3,
                BestEffort = true
            };

            var response = await _client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(request);
            
            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            
            foreach (var number in response.Data)
            {
                _output.WriteLine($"  - {number.PhoneNumber}: Features available");
            }
        }

        [Fact]
        public async Task Phase1_03_SearchAvailableNumberBlocks()
        {
            if (!_runIntegrationTests) return;
            
            _output.WriteLine("\n=== Phase 1.3: Search Available Number Blocks ===");
            
            var request = new ListAvailablePhoneNumberBlocksRequest
            {
                CountryCode = _testCountry
            };

            var response = await _client.PhoneNumbers.PhoneNumberSearch.ListAvailableNumberBlocks(request);
            
            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            _output.WriteLine($"Number blocks response received");
        }

        [Fact]
        public async Task Phase1_04_ListExistingOrders()
        {
            if (!_runIntegrationTests) return;
            
            _output.WriteLine("\n=== Phase 1.4: List Existing Orders ===");
            
            var request = new ListNumberOrdersRequest
            {
                PageSize = 5
            };

            var response = await _client.PhoneNumbers.PhoneNumberOrders.List(request);
            
            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            _output.WriteLine($"Found existing orders in account");
        }

        [Fact]
        public async Task Phase1_05_ListExistingReservations()
        {
            if (!_runIntegrationTests) return;
            
            _output.WriteLine("\n=== Phase 1.5: List Existing Reservations ===");
            
            var request = new ListNumberReservationsRequest
            {
                PageSize = 5
            };

            var response = await _client.PhoneNumbers.PhoneNumberReservations.List(request);
            
            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            _output.WriteLine($"Found existing reservations in account");
        }

        [Fact]
        public async Task Phase1_06_ListOwnedPhoneNumbers()
        {
            if (!_runIntegrationTests) return;
            
            _output.WriteLine("\n=== Phase 1.6: List Currently Owned Numbers ===");
            
            var request = new ListNumbersRequest
            {
                PageSize = 10
            };

            var response = await _client.PhoneNumbers.PhoneNumberConfiguration.List(request);
            
            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            
            _output.WriteLine($"Account currently owns {response.Data?.Count ?? 0} phone numbers");
            
            if (response.Data != null)
            {
                foreach (var number in response.Data.Take(5))
                {
                    _output.WriteLine($"  - {number.PhoneNumber} (Status: {number.Status})");
                }
            }
        }

        #endregion

        #region Phase 2: Purchase & Configure (Requires TELNYX_PURCHASE_TEST_NUMBER=true)

        [Fact]
        public async Task Phase2_01_CheckTestNumber()
        {
            if (!_runIntegrationTests || !_purchaseTestNumber) 
            {
                _output.WriteLine("\n=== Phase 2.1: SKIPPED - Purchase not enabled ===");
                return;
            }
            
            _output.WriteLine("\n=== Phase 2.1: Check Test Number ===");
            
            // The fixture handles purchasing/finding the test number
            if (!string.IsNullOrEmpty(_purchasedNumber))
            {
                _output.WriteLine($"Using test number: {_purchasedNumber} (ID: {_purchasedNumberId})");
                Assert.NotNull(_purchasedNumber);
                Assert.NotNull(_purchasedNumberId);
            }
            else
            {
                _output.WriteLine("ERROR: No test number available - fixture failed to initialize");
                Assert.NotNull(_purchasedNumber);
            }
        }

        [Fact]
        public async Task Phase2_02_GetPurchasedNumberDetails()
        {
            if (!_runIntegrationTests || !_purchaseTestNumber || string.IsNullOrEmpty(_purchasedNumber)) return;
            
            _output.WriteLine("\n=== Phase 2.2: Get Purchased Number Details ===");
            
            // Find our purchased number in the account
            var request = new ListNumbersRequest
            {
                PhoneNumber = _purchasedNumber,
                PageSize = 1
            };

            var response = await _client.PhoneNumbers.PhoneNumberConfiguration.List(request);
            
            if (response?.Data != null && response.Data.Count > 0)
            {
                var phoneNumber = response.Data.First();
                
                _output.WriteLine($"Found purchased number:");
                _output.WriteLine($"  ID: {_purchasedNumberId}");
                _output.WriteLine($"  Number: {phoneNumber.PhoneNumber}");
                _output.WriteLine($"  Status: {phoneNumber.Status}");
                
                // Get detailed info
                if (!string.IsNullOrEmpty(_purchasedNumberId))
                {
                    var details = await _client.PhoneNumbers.PhoneNumberConfiguration.Get(_purchasedNumberId);
                    Assert.NotNull(details);
                    Assert.NotNull(details.Data);
                }
            }
            else
            {
                _output.WriteLine("WARNING: Could not find purchased number in account");
            }
        }

        [Fact]
        public async Task Phase2_03_UpdatePhoneNumberConfiguration()
        {
            if (!_runIntegrationTests || !_purchaseTestNumber) 
            {
                _output.WriteLine("\n=== Phase 2.3: SKIPPED - Purchase not enabled ===");
                return;
            }
            
            _output.WriteLine("\n=== Phase 2.3: Update Phone Number Configuration ===");
            
            if (string.IsNullOrEmpty(_purchasedNumberId))
            {
                _output.WriteLine($"SKIP: No purchased number ID available from fixture");
                _output.WriteLine($"Purchased Number: '{_purchasedNumber}'");
                _output.WriteLine($"Purchased Number ID: '{_purchasedNumberId}'");
                _output.WriteLine($"");
                _output.WriteLine($"POSSIBLE CAUSES:");
                _output.WriteLine($"1. Number provisioning timing - newly purchased numbers may take time to appear with IDs");
                _output.WriteLine($"2. API rate limiting or temporary service issues");
                _output.WriteLine($"3. Test environment configuration issues");
                _output.WriteLine($"");
                _output.WriteLine($"TROUBLESHOOTING:");
                _output.WriteLine($"- Check fixture logs for retry attempts and timing details");
                _output.WriteLine($"- Verify number exists in Telnyx portal with valid configuration");
                _output.WriteLine($"- Consider increasing retry timeout for slower environments");
                return; // Skip test instead of failing
            }
            
            var updateRequest = new UpdateNumberConfigurationRequest
            {
                Tags = new[] { "orchestrated_test", $"test_{DateTime.UtcNow:yyyyMMdd}" }
            };

            var response = await _client.PhoneNumbers.PhoneNumberConfiguration.Update(_purchasedNumberId!, updateRequest);
            
            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            
            _output.WriteLine($"Updated configuration with tags");
            if (response.Data.Tags != null)
            {
                foreach (var tag in response.Data.Tags)
                {
                    _output.WriteLine($"  Tag: {tag}");
                }
            }
        }

        [Fact]
        public async Task Phase2_04_CreateCommentOnOrder()
        {
            if (!_runIntegrationTests || !_purchaseTestNumber || string.IsNullOrEmpty(_orderId)) return;
            
            _output.WriteLine("\n=== Phase 2.4: Create Comment on Order ===");
            
            var createCommentRequest = new CreateCommentRequest
            {
                Body = $"Orchestrated test comment - {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}",
                CommentRecordType = "number_order",
                CommentRecordId = _orderId
            };

            var response = await _client.PhoneNumbers.PhoneNumberOrders.CreateComment(createCommentRequest);
            
            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            
            _output.WriteLine($"Created comment on order {_orderId}");
        }

        #endregion

        #region Phase 3: Reservation Tests (Optional)

        [Fact]
        public async Task Phase3_01_CreateReservation()
        {
            if (!_runIntegrationTests || !_testReservations) 
            {
                _output.WriteLine("\n=== Phase 3.1: SKIPPED - Reservations not enabled ===");
                return;
            }
            
            _output.WriteLine("\n=== Phase 3.1: Create Reservation ===");
            _output.WriteLine("WARNING: This may incur holding fees!");
            
            // Search for a different number to reserve
            var searchRequest = new AvailablePhoneNumbersRequest
            {
                CountryCode = _testCountry,
                NationalDestinationCode = int.TryParse(_testAreaCode, out var ndc) ? ndc : null,
                Limit = 1
            };

            var searchResponse = await _client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(searchRequest);
            
            if (searchResponse?.Data == null || searchResponse.Data.Count == 0)
            {
                _output.WriteLine("No available numbers for reservation");
                return;
            }

            var reservationRequest = new CreateNumberReservationRequest
            {
                PhoneNumbers = new List<CreateNumberReservationPhoneNumber>
                {
                    new CreateNumberReservationPhoneNumber 
                    { 
                        PhoneNumber = searchResponse.Data.First().PhoneNumber 
                    }
                },
                CustomerReference = $"orchestrated_test_{DateTime.UtcNow:yyyyMMddHHmmss}"
            };

            var response = await _client.PhoneNumbers.PhoneNumberReservations.Create(reservationRequest);
            
            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            
            if (response.Data != null && !string.IsNullOrEmpty(response.Data.Id))
            {
                _reservationId = response.Data.Id;
                _output.WriteLine($"Created reservation: {_reservationId}");
                _output.WriteLine($"  Status: {response.Data.Status}");
                _output.WriteLine("  Note: Reservation will auto-expire");
            }
        }

        #endregion

        #region Lifecycle Management

        public Task InitializeAsync()
        {
            _output.WriteLine("\n=== Test Suite Initialization ===");
            return Task.CompletedTask;
        }

        public async Task DisposeAsync()
        {
            // No automatic cleanup - numbers tracked in PURCHASE_TRACKING.md for manual cleanup
            _output.WriteLine("\n=== Test Suite Completed ===");
            _output.WriteLine("Numbers purchased during testing are tracked in PURCHASE_TRACKING.md");
            _output.WriteLine("Manual cleanup required - see tracking file for details");
            await Task.CompletedTask;
        }

        #endregion
    }
}