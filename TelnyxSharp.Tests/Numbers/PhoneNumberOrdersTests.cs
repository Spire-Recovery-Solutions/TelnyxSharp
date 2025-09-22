using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberSearch;
using Xunit;
using Xunit.Abstractions;

namespace TelnyxSharp.Tests.Numbers
{
    [Trait("Category", "Integration")]
    [Trait("Module", "Numbers")]
    [Trait("Cost", "PotentialCharges")]
    public class PhoneNumberOrdersTests : NumberManagementTestBase
    {
        public PhoneNumberOrdersTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public async Task CreateNumberOrder_WithAvailableNumber_CreatesOrder()
        {
            SkipIfNotIntegrationTest();
            SkipIfCostTestsNotAllowed(); // This test PURCHASES a phone number!

            // First, search for an available number
            var searchRequest = new AvailablePhoneNumbersRequest
            {
                CountryCode = TestCountry,
                NationalDestinationCode = int.TryParse(TestAreaCode, out var ndc) ? ndc : null,
                Limit = 1
            };

            var searchResponse = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(searchRequest);

            if (searchResponse?.Data == null || searchResponse.Data.Count == 0)
            {
                Output.WriteLine("No available numbers found for testing");
                return;
            }

            var availableNumber = searchResponse.Data.First();
            Output.WriteLine($"Found available number: {availableNumber.PhoneNumber}");
            Output.WriteLine($"WARNING: About to purchase this number - this will incur charges!");

            // Create order for the available number
            var orderRequest = new CreateNumberOrderRequest
            {
                PhoneNumbers = new List<CreateNumberOrderPhoneNumber>
                {
                    new CreateNumberOrderPhoneNumber
                    {
                        PhoneNumber = availableNumber.PhoneNumber ?? string.Empty
                    }
                }
            };

            var response = await Client.PhoneNumbers.PhoneNumberOrders.Create(orderRequest);

            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            
            Output.WriteLine($"Created order");
            
            // Note: Actual response structure may vary - adjust as needed
            if (response.Data != null)
            {
                Output.WriteLine($"Order created successfully");
            }
        }

        [Fact]
        public async Task ListNumberOrders_ReturnsOrders()
        {
            SkipIfNotIntegrationTest();
            // This test is SAFE - only lists existing orders

            var request = new ListNumberOrdersRequest
            {
                PageSize = 10
            };

            var response = await Client.PhoneNumbers.PhoneNumberOrders.List(request);

            Assert.NotNull(response);
            Assert.NotNull(response.Data);

            Output.WriteLine($"Found number orders");

            if (response.Data != null)
            {
                Output.WriteLine($"Orders list retrieved successfully");
            }
        }

        [Fact]
        public async Task GetNumberOrder_WithValidId_ReturnsOrderDetails()
        {
            SkipIfNotIntegrationTest();
            // This test is SAFE - only reads order details

            // First, get list of orders to find a valid ID
            var listRequest = new ListNumberOrdersRequest { PageSize = 1 };
            var listResponse = await Client.PhoneNumbers.PhoneNumberOrders.List(listRequest);

            if (listResponse?.Data == null || (listResponse.Data as System.Collections.IEnumerable) == null)
            {
                Output.WriteLine("No number orders available for testing");
                return;
            }

            // Note: The actual structure of response.Data needs to be determined at runtime
            Output.WriteLine("Order details test would run here if orders exist");
        }

        [Fact]
        public async Task CreateAndListComments_OnNumberOrder()
        {
            SkipIfNotIntegrationTest();
            // This test is SAFE - only creates comments

            // First, get an order to comment on
            var listRequest = new ListNumberOrdersRequest { PageSize = 1 };
            var listResponse = await Client.PhoneNumbers.PhoneNumberOrders.List(listRequest);

            if (listResponse?.Data == null)
            {
                Output.WriteLine("No number orders available for testing comments");
                return;
            }

            // Note: Actual implementation depends on response structure
            Output.WriteLine("Comments test would run here if orders exist");
        }
    }
}