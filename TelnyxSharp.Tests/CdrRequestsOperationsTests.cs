using TelnyxSharp.V1Operations.Models.Requests;
namespace TelnyxSharp.Tests;

public class CdrRequestsOperationsTests : TelnyxTestBase
{
    private readonly TelnyxClient _telnyxClient;

    public CdrRequestsOperationsTests()
    {
        var apiKey = "set me"
                         ?? throw new InvalidOperationException("TELNYX_API_KEY not set");
        var v1ApiUser = "set me";
        var v1ApiToken = "set me"
                         ?? throw new InvalidOperationException("TELNYX_V1_API_TOKEN not set");

        _telnyxClient = new TelnyxClient(apiKey, v1ApiUser, v1ApiToken);
    }

    [Fact]
    public async Task FullCdrRequestLifecycle_Succeeds()
    {
        var id = await CreateCdrRequestAsync();
        
        try
        {
            await ListCdrRequestsAsync(id);
            await GetCdrRequestAsync(id);
            await DeleteCdrRequestAsync(id);
        }
        catch
        {
            await CleanupCdrRequestAsync(id);
            throw;
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
            await ListCdrRequestsAsync(id);
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
            await GetCdrRequestAsync(id);
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
        await DeleteCdrRequestAsync(id);
        // No need for cleanup as we just deleted it
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

    private async Task CleanupCdrRequestAsync(string id)
    {
        if (!string.IsNullOrEmpty(id))
        {
            try
            {
                await _telnyxClient.V1.CdrRequests.Delete(id, CancellationToken.None);
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