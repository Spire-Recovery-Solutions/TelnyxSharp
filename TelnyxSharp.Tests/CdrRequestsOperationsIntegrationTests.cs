using TelnyxSharp.V1Operations.Models.Requests;
namespace TelnyxSharp.Tests;

public class CdrRequestsOperationsIntegrationTests : IDisposable
{
    private readonly TelnyxClient _telnyxClient;
    private string? _createdCdrRequestId;

    public CdrRequestsOperationsIntegrationTests()
    {
        var apiKey = "TELNYX_API_KEY"
                         ?? throw new InvalidOperationException("TELNYX_API_KEY not set");
        var v1ApiToken = "TELNYX_V1_API_TOKEN"
                         ?? throw new InvalidOperationException("TELNYX_V1_API_TOKEN not set");

        _telnyxClient = new TelnyxClient(apiKey, v1ApiToken);
    }

    [Fact]
    public async Task FullCdrRequestLifecycle_Succeeds()
    {
        var id = await CreateCdrRequestAsync();

        await ListCdrRequestsAsync(id);
        await GetCdrRequestAsync(id);
        await DeleteCdrRequestAsync(id);
    }

    [Fact]
    public async Task Create_WithMinimalFields_Succeeds()
    {
        _createdCdrRequestId = await CreateCdrRequestAsync();
        Assert.False(string.IsNullOrEmpty(_createdCdrRequestId));
    }

    [Fact]
    public async Task List_ReturnsCreatedRequest()
    {
        _createdCdrRequestId = await CreateCdrRequestAsync();
        await ListCdrRequestsAsync(_createdCdrRequestId);
    }

    [Fact]
    public async Task Get_ExistingCdrRequest_ReturnsCorrectData()
    {
        _createdCdrRequestId = await CreateCdrRequestAsync();
        await GetCdrRequestAsync(_createdCdrRequestId);
    }

    [Fact]
    public async Task Delete_ExistingCdrRequest_Succeeds()
    {
        var id = await CreateCdrRequestAsync();
        await DeleteCdrRequestAsync(id);
    }

    private async Task<string> CreateCdrRequestAsync()
    {
        var now = DateTime.UtcNow;
        var req = new CreateCdrRequestsRequest
        {
            StartTime = now.AddHours(-1).ToString("o"),
            EndTime = now.ToString("o"),
            CallTypes = new List<int> { 1 },
            RecordTypes = new List<int> { 1 },
            Connections = new List<string> { "conn_1234567890" },
            ReportName = "TestReport_" + Guid.NewGuid(),
            Source = "calls"
        };

        var resp = await _telnyxClient.V1
            .CdrRequests
            .Create(req, CancellationToken.None);

        Assert.NotNull(resp);
        Assert.False(string.IsNullOrEmpty(resp.Id));
        _createdCdrRequestId = resp.Id;
        return resp.Id;
    }

    private async Task ListCdrRequestsAsync(string expectedId)
    {
        var req = new ListCdrRequestsRequest { PageSize = 10 };
        var list = await _telnyxClient
            .V1
            .CdrRequests
            .List(req, CancellationToken.None);

        Assert.NotNull(list);
        Assert.Contains(list, r => r.Id == expectedId);
    }

    private async Task GetCdrRequestAsync(string id)
    {
        var resp = await _telnyxClient
            .V1
            .CdrRequests
            .Get(id, CancellationToken.None);

        Assert.NotNull(resp);
        Assert.Equal(id, resp.Id);
    }

    private async Task DeleteCdrRequestAsync(string id)
    {
        var resp = await _telnyxClient
            .V1
            .CdrRequests
            .Delete(id, CancellationToken.None);

        Assert.NotNull(resp);
        Assert.True(resp.Success, $"Expected deletion of CDR Request {id} to succeed, but got: {resp.Message}");
    }


    public void Dispose()
    {
        if (!string.IsNullOrEmpty(_createdCdrRequestId))
        {
            try
            {
                _telnyxClient.V1.CdrRequests
                    .Delete(_createdCdrRequestId, CancellationToken.None)
                    .GetAwaiter().GetResult();
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Failed to delete CDR Request {_createdCdrRequestId}: {ex.Message}");
            }
            finally
            {
                _createdCdrRequestId = null;
            }
        }
        _telnyxClient.Dispose();
    }
}
