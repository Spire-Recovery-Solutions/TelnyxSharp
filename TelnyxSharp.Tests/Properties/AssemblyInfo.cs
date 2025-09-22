using Xunit;

// Configure xUnit test execution behavior
// Disable test parallelization to ensure integration tests run sequentially
// This prevents race conditions and resource conflicts between test phases
[assembly: CollectionBehavior(DisableTestParallelization = true)]