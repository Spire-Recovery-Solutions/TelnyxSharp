using TelnyxSharp.V1Operations.Models.Requests;

namespace TelnyxSharp.Tests
{
    public class CdrRequestsOperationsTests : IDisposable
    {
        private readonly TelnyxClient _telnyxClient;

        public CdrRequestsOperationsTests()
        {
            var apiKey = "TELNYX_API_KEY"
                ?? throw new InvalidOperationException("TELNYX_API_KEY environment variable not set");
            var v1ApiToken = "TELNYX_V1_API_TOKEN"
                ?? throw new InvalidOperationException("TELNYX_V1_API_TOKEN environment variable not set");

            _telnyxClient = new TelnyxClient(apiKey, v1ApiToken);
        }

        [Fact]
        public async Task FullCdrRequestLifecycle_Succeeds()
        {
            var id = await CreateCdrRequestAsync();
            try
            {
                // Test each operation in sequence
                var listResult = await ListCdrRequestsAsync(id);
                Assert.Contains(listResult, r => r.Id == id);

                var getResult = await GetCdrRequestAsync(id);
                Assert.Equal(id, getResult.Id);

                var deleteResult = await DeleteCdrRequestAsync(id);
                Assert.True(deleteResult.Success);
            }
            finally
            {
                try
                {
                    await _telnyxClient.V1.CdrRequests.Delete(id, CancellationToken.None);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Failed to delete CDR Request {id} during cleanup: {ex.Message}");
                }
                finally
                {
                    await CleanupCdrRequestAsync(id);
                }
            }
        }

        [Fact]
        public async Task Create_WithMinimalFields_Succeeds()
        {
            var id = await CreateCdrRequestAsync();
            try
            {
                Assert.False(string.IsNullOrEmpty(id));
            }
            finally
            {
                await CleanupCdrRequestAsync(id);
            }
        }

        [Fact]
        public async Task List_ReturnsCreatedRequest()
        {
            var id = await CreateCdrRequestAsync();
            try
            {
                var results = await ListCdrRequestsAsync(id);
                Assert.Contains(results, r => r.Id == id);
            }
            finally
            {
                await CleanupCdrRequestAsync(id);
            }
        }

        [Fact]
        public async Task Get_ExistingCdrRequest_ReturnsCorrectData()
        {
            var id = await CreateCdrRequestAsync();
            try
            {
                var result = await GetCdrRequestAsync(id);
                Assert.Equal(id, result.Id);
                Assert.NotNull(result.ReportName);
                Assert.Equal("calls", result.Source);
            }
            finally
            {
                await CleanupCdrRequestAsync(id);
            }
        }

        [Fact]
        public async Task Delete_ExistingCdrRequest_Succeeds()
        {
            var id = await CreateCdrRequestAsync();
            var result = await DeleteCdrRequestAsync(id);
            Assert.True(result.Success);
        }

        [Fact]
        public async Task Get_NonExistentCdrRequest_ThrowsException()
        {
            var nonExistentId = "cdr_" + Guid.NewGuid().ToString("N");
            await Assert.ThrowsAsync<Exception>(() =>
                _telnyxClient.V1.CdrRequests.Get(nonExistentId, CancellationToken.None));
        }

        private async Task<string> CreateCdrRequestAsync()
        {
            var now = DateTime.UtcNow;
            var connectionId = "TEST_CONNECTION_ID";

            var req = new CreateCdrRequestsRequest
            {
                StartTime = now.AddHours(-1).ToString("o"),
                EndTime = now.ToString("o"),
                CallTypes = new List<int> { 1 },
                RecordTypes = new List<int> { 1 },
                Connections = new List<string> { connectionId },
                ReportName = "TestReport_" + Guid.NewGuid(),
                Source = "calls"
            };

            var resp = await _telnyxClient.V1
                .CdrRequests
                .Create(req, CancellationToken.None);

            Assert.NotNull(resp);
            Assert.False(string.IsNullOrEmpty(resp.Id));
            return resp.Id;
        }

        private async Task<IEnumerable<dynamic>> ListCdrRequestsAsync(string expectedId)
        {
            var req = new ListCdrRequestsRequest { PageSize = 10 };
            var list = await _telnyxClient
                .V1
                .CdrRequests
                .List(req, CancellationToken.None);

            Assert.NotNull(list);
            return list;
        }

        private async Task<dynamic> GetCdrRequestAsync(string id)
        {
            var resp = await _telnyxClient
                .V1
                .CdrRequests
                .Get(id, CancellationToken.None);

            Assert.NotNull(resp);
            return resp;
        }

        private async Task<dynamic> DeleteCdrRequestAsync(string id)
        {
            var resp = await _telnyxClient
                .V1
                .CdrRequests
                .Delete(id, CancellationToken.None);

            Assert.NotNull(resp);
            return resp;
        }

        private async Task CleanupCdrRequestAsync(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                try
                {
                    await _telnyxClient.V1.CdrRequests
                        .Delete(id, CancellationToken.None);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to delete CDR Request {id} during cleanup: {ex.Message}");
                }
            }
        }

        public void Dispose()
        {
            _telnyxClient.Dispose();
        }
    }
}