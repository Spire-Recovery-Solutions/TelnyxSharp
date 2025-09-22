# Number Management Integration Tests - Safety Guide

## Environment Variables

- `TELNYX_API_KEY`: Required for all tests
- `TELNYX_ALLOW_COST_TESTS`: Required to run tests that incur charges (default: false)
- `TELNYX_TEST_AREA_CODE`: Area code for test numbers (default: 212)
- `TELNYX_TEST_COUNTRY`: Country for test numbers (default: US)
- `TELNYX_TEST_CLEANUP`: Enable cleanup after tests (default: true)
- `TELNYX_TEST_MAX_NUMBERS`: Maximum numbers to test with (default: 5)

## Test Categories

### SAFE Tests (No Charges)
These tests only read data or work with existing resources:

#### PhoneNumberSearchTests.cs
- `SearchAvailableNumbers_*` - Only searches for available numbers
- `ListAvailableNumberBlocks_*` - Only lists number blocks
- All tests in this file are READ-ONLY

#### PhoneNumberConfigurationTests.cs
- `ListPhoneNumbers_*` - Lists owned numbers
- `GetPhoneNumber_*` - Gets details of owned numbers
- `UpdatePhoneNumberConfiguration_*` - Updates configuration of existing numbers
- `UpdatePhoneNumberVoiceSettings_*` - Updates voice settings
- All tests work with EXISTING owned numbers only

#### PhoneNumberOrdersTests.cs (SAFE tests only)
- `ListNumberOrders_ReturnsOrders` - Lists existing orders
- `GetNumberOrder_WithValidId_ReturnsOrderDetails` - Gets order details
- `UpdateNumberOrder_ModifiesOrderDetails` - Updates order metadata
- `ListSubNumberOrders_ReturnsSubOrders` - Lists sub-orders
- `CreateAndListComments_OnNumberOrder` - Creates comments (no charge)

#### PhoneNumberReservationsTests.cs (SAFE tests only)
- `ListReservations_ReturnsReservations` - Lists existing reservations
- `GetReservation_WithValidId_ReturnsReservationDetails` - Gets reservation details
- `ListReservations_WithFilters_ReturnsFilteredResults` - Lists with filters

### DANGEROUS Tests (Incur Charges)
These tests WILL incur charges and require `TELNYX_ALLOW_COST_TESTS=true`:

#### PhoneNumberOrdersTests.cs
- `CreateNumberOrder_WithAvailableNumber_CreatesOrder` - **PURCHASES a phone number**
  - Protected with: `SkipIfCostTestsNotAllowed()`
  - Cost: Monthly recurring charge for the number

#### PhoneNumberReservationsTests.cs
- `CreateReservation_WithAvailableNumbers_CreatesReservation` - **Creates number reservation**
  - Protected with: `SkipIfCostTestsNotAllowed()`
  - Cost: Potential holding fees
  
- `ExtendReservation_ExtendsExpirationTime` - **Extends reservation**
  - Protected with: `SkipIfCostTestsNotAllowed()`
  - Cost: Additional holding fees
  
- `ReservationExpiration_TracksExpirationTime` - **Creates reservation**
  - Protected with: `SkipIfCostTestsNotAllowed()`
  - Cost: Potential holding fees

## Running Tests Safely

### To run ONLY safe tests:
```bash
~/.dotnet/dotnet test --filter "Category=Integration&Module=Numbers" 
```

### To run ALL tests including cost-incurring:
```bash
export TELNYX_ALLOW_COST_TESTS=true
~/.dotnet/dotnet test --filter "Category=Integration&Module=Numbers"
```

### To run specific safe test classes:
```bash
~/.dotnet/dotnet test --filter "FullyQualifiedName~PhoneNumberSearchTests"
~/.dotnet/dotnet test --filter "FullyQualifiedName~PhoneNumberConfigurationTests"
```

## Cleanup Behavior

When `TELNYX_TEST_CLEANUP=true` (default), the tests will attempt to clean up:
- Phone numbers that were purchased (delete them to stop recurring charges)
- Reservations are tracked but expire automatically
- Orders are tracked but cannot be deleted

## Debug Logging

All integration tests automatically enable debug logging to capture API requests/responses.
Logs are written to: `./debug_logs/telnyx_api_YYYYMMDD_HHMMSS.log`

## Important Notes

1. **Production API**: These tests run against the PRODUCTION Telnyx API
2. **Real Charges**: Cost-incurring tests will charge your Telnyx account
3. **Cleanup**: Even with cleanup enabled, some charges may be non-refundable
4. **Reservations**: Expire automatically after a timeout period
5. **Phone Numbers**: Once purchased, incur monthly charges until deleted