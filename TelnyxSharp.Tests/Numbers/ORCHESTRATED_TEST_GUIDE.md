# Orchestrated Number Management Integration Tests Guide

## Overview
The orchestrated test suite executes tests in a specific order to minimize costs and side effects when testing against the production Telnyx API.

## Test Execution Phases

### Phase 1: Read-Only Tests (FREE - No Purchase Required)
These tests run first and don't modify any data:
1. **Search Tests** - Find available numbers
   - SearchAvailableNumbers_ByAreaCode
   - SearchAvailableNumbers_WithFeatures  
   - SearchAvailableNumberBlocks
2. **List Tests** - View existing data
   - ListExistingOrders
   - ListExistingReservations
   - ListOwnedPhoneNumbers

**Important**: Phase 1 captures an available number for potential purchase in Phase 2.

### Phase 2: Purchase & Configure (COSTS MONEY - Requires Permission)
Only runs if `TELNYX_PURCHASE_TEST_NUMBER=true`:
1. **PurchaseTestNumber** - Buys ONE number found in Phase 1
2. **Configuration Tests** - Uses the purchased number
   - GetPurchasedNumberDetails
   - UpdatePhoneNumberConfiguration (tags)
   - CreateCommentOnOrder

### Phase 3: Reservation Tests (MAY COST - Optional)
Only runs if `TELNYX_TEST_RESERVATIONS=true`:
1. **CreateReservation** - Reserve a different number (may incur holding fees)
2. Reservations auto-expire (no cleanup needed)

### Phase 4: Cleanup (Automatic)
Runs in `DisposeAsync`:
- Releases the purchased test phone number
- Logs any cleanup failures

## Required Environment Variables

### Minimum Required for Read-Only Tests
```bash
export TELNYX_API_KEY="KEY0123456789..."
export TELNYX_RUN_INTEGRATION_TESTS=true
```

### To Enable Purchase Tests (COSTS MONEY)
```bash
export TELNYX_PURCHASE_TEST_NUMBER=true
```

### Optional Configuration
```bash
export TELNYX_TEST_RESERVATIONS=true  # Enable reservation tests
export TELNYX_TEST_AREA_CODE=212      # Area code for searches (default: 212)
export TELNYX_TEST_COUNTRY=US         # Country for searches (default: US)
```

## Running the Tests

### Run ONLY Read-Only Tests (FREE)
```bash
# Only Phase 1 will execute
export TELNYX_API_KEY="your_key"
export TELNYX_RUN_INTEGRATION_TESTS=true

~/.dotnet/dotnet test TelnyxSharp.Tests/TelnyxSharp.Tests.csproj \
  --filter "FullyQualifiedName~OrchestratedNumberManagementTests" \
  --logger "console;verbosity=detailed"
```

### Run Full Test Suite (INCLUDING PURCHASE)
```bash
# All phases will execute
export TELNYX_API_KEY="your_key"
export TELNYX_RUN_INTEGRATION_TESTS=true
export TELNYX_PURCHASE_TEST_NUMBER=true  # ⚠️ WILL PURCHASE A NUMBER

~/.dotnet/dotnet test TelnyxSharp.Tests/TelnyxSharp.Tests.csproj \
  --filter "FullyQualifiedName~OrchestratedNumberManagementTests" \
  --logger "console;verbosity=detailed"
```

## Test Output
- Console output shows each phase and test result
- Debug logs saved to: `./debug_logs/orchestrated_test_YYYYMMDD_HHMMSS.log`
- Captures all API requests/responses for debugging

## Cost Summary

| Phase | Cost | What Happens |
|-------|------|-------------|
| Phase 1 | FREE | Search and list operations only |
| Phase 2 | ~$1-2/month | Purchases ONE phone number |
| Phase 3 | Possible fees | May incur reservation holding fees |
| Cleanup | FREE | Releases purchased number (stops recurring charges) |

## Important Notes

1. **Test Order Matters**: Tests run in order using xUnit's `[Order]` attribute
2. **Single Number Purchase**: Only ONE number is purchased for all tests
3. **Automatic Cleanup**: The purchased number is released after tests complete
4. **Failed Cleanup Warning**: If cleanup fails, manual deletion may be required
5. **Production API**: These tests run against your real Telnyx account

## Troubleshooting

### Tests Skip Phase 2
- Verify `TELNYX_PURCHASE_TEST_NUMBER=true` is set
- Check that Phase 1 found available numbers

### Cleanup Failed
- Check the console output for the phone number ID
- Manually delete via Telnyx portal or API
- Review debug logs for error details

### No Available Numbers
- Try different area code with `TELNYX_TEST_AREA_CODE`
- Check account permissions and balance