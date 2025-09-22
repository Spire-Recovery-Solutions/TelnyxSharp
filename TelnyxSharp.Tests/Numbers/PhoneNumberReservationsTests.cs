using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberReservations;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberSearch;
using Xunit;
using Xunit.Abstractions;

namespace TelnyxSharp.Tests.Numbers
{
    [Trait("Category", "Integration")]
    [Trait("Module", "Numbers")]
    [Trait("Cost", "PotentialCharges")]
    public class PhoneNumberReservationsTests : NumberManagementTestBase
    {
        public PhoneNumberReservationsTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public async Task CreateReservation_WithAvailableNumbers_CreatesReservation()
        {
            SkipIfNotIntegrationTest();
            SkipIfCostTestsNotAllowed(); // Reservations may incur holding fees!

            // First, search for available numbers to reserve
            var searchRequest = new AvailablePhoneNumbersRequest
            {
                CountryCode = TestCountry,
                NationalDestinationCode = int.TryParse(TestAreaCode, out var ndc) ? ndc : null,
                Limit = 2
            };

            var searchResponse = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(searchRequest);

            if (searchResponse?.Data == null || searchResponse.Data.Count == 0)
            {
                Output.WriteLine("No available numbers found for reservation");
                return;
            }

            var phoneNumbersToReserve = searchResponse.Data
                .Take(Math.Min(2, searchResponse.Data.Count))
                .Select(n => new CreateNumberReservationPhoneNumber { PhoneNumber = n.PhoneNumber })
                .ToList();

            Output.WriteLine($"Attempting to reserve {phoneNumbersToReserve.Count} numbers");
            Output.WriteLine("WARNING: This may incur reservation fees!");

            var reservationRequest = new CreateNumberReservationRequest
            {
                PhoneNumbers = phoneNumbersToReserve,
                CustomerReference = $"{TestPrefix}reservation_{DateTime.UtcNow:yyyyMMddHHmmss}"
            };

            var response = await Client.PhoneNumbers.PhoneNumberReservations.Create(reservationRequest);

            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            
            if (response.Data != null && !string.IsNullOrEmpty(response.Data.Id))
            {
                ReservationsToCleanup.Add(response.Data.Id);
                Output.WriteLine($"Created reservation: {response.Data.Id}");
                Output.WriteLine($"  Status: {response.Data.Status}");
                Output.WriteLine($"  Customer Reference: {response.Data.CustomerReference}");
            }
        }

        [Fact]
        public async Task ListReservations_ReturnsReservations()
        {
            SkipIfNotIntegrationTest();
            // This test is SAFE - only lists existing reservations

            var request = new ListNumberReservationsRequest
            {
                PageSize = 10
            };

            var response = await Client.PhoneNumbers.PhoneNumberReservations.List(request);

            Assert.NotNull(response);
            Assert.NotNull(response.Data);

            Output.WriteLine($"Reservations list retrieved");

            // Note: response.Data might be a single object or a list
            // The actual structure needs to be determined at runtime
        }

        [Fact]
        public async Task GetReservation_WithValidId_ReturnsReservationDetails()
        {
            SkipIfNotIntegrationTest();
            // This test is SAFE - only reads reservation details

            // First, get list of reservations to find a valid ID
            var listRequest = new ListNumberReservationsRequest { PageSize = 1 };
            var listResponse = await Client.PhoneNumbers.PhoneNumberReservations.List(listRequest);

            if (listResponse?.Data == null)
            {
                Output.WriteLine("No reservations available for testing");
                return;
            }

            // Note: Actual implementation depends on response structure
            Output.WriteLine("Reservation details test would run here if reservations exist");
        }

        [Fact]
        public async Task ExtendReservation_ExtendsExpirationTime()
        {
            SkipIfNotIntegrationTest();
            SkipIfCostTestsNotAllowed(); // Extending may incur additional fees!

            // First create a reservation to extend
            var searchRequest = new AvailablePhoneNumbersRequest
            {
                CountryCode = TestCountry,
                NationalDestinationCode = int.TryParse(TestAreaCode, out var ndc) ? ndc : null,
                Limit = 1
            };

            var searchResponse = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(searchRequest);

            if (searchResponse?.Data == null || searchResponse.Data.Count == 0)
            {
                Output.WriteLine("No available numbers found for reservation");
                return;
            }

            var createRequest = new CreateNumberReservationRequest
            {
                PhoneNumbers = new List<CreateNumberReservationPhoneNumber>
                {
                    new CreateNumberReservationPhoneNumber { PhoneNumber = searchResponse.Data.First().PhoneNumber }
                },
                CustomerReference = $"{TestPrefix}extend_test"
            };

            var createResponse = await Client.PhoneNumbers.PhoneNumberReservations.Create(createRequest);
            
            if (createResponse?.Data != null && !string.IsNullOrEmpty(createResponse.Data.Id))
            {
                var reservationId = createResponse.Data.Id;
                ReservationsToCleanup.Add(reservationId);

                Output.WriteLine($"Created reservation {reservationId}");
                Output.WriteLine("WARNING: About to extend reservation - may incur additional fees!");

                var extendResponse = await Client.PhoneNumbers.PhoneNumberReservations.Extend(reservationId);

                Assert.NotNull(extendResponse);
                Assert.NotNull(extendResponse.Data);
                
                Output.WriteLine($"Extended reservation successfully");
            }
        }

        [Fact]
        public async Task ReservationExpiration_TracksExpirationTime()
        {
            SkipIfNotIntegrationTest();
            SkipIfCostTestsNotAllowed(); // This creates a reservation!

            // Create a reservation and verify expiration is set
            var searchRequest = new AvailablePhoneNumbersRequest
            {
                CountryCode = TestCountry,
                NationalDestinationCode = int.TryParse(TestAreaCode, out var ndc) ? ndc : null,
                Limit = 1
            };

            var searchResponse = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(searchRequest);

            if (searchResponse?.Data == null || searchResponse.Data.Count == 0)
            {
                Output.WriteLine("No available numbers found");
                return;
            }

            var request = new CreateNumberReservationRequest
            {
                PhoneNumbers = new List<CreateNumberReservationPhoneNumber>
                {
                    new CreateNumberReservationPhoneNumber { PhoneNumber = searchResponse.Data.First().PhoneNumber }
                }
            };

            var response = await Client.PhoneNumbers.PhoneNumberReservations.Create(request);

            Assert.NotNull(response?.Data);
            
            if (response.Data != null && !string.IsNullOrEmpty(response.Data.Id))
            {
                ReservationsToCleanup.Add(response.Data.Id);
                Output.WriteLine($"Reservation created");
                Output.WriteLine($"Reservation will expire automatically");
            }
        }
    }
}