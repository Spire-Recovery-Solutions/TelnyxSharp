using TelnyxSharp.Enums;
using TelnyxSharp.V1Operations.Models.Requests;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace TelnyxSharp.Tests;

public sealed class CdrRequestsOperationsTests : TelnyxTestBase
{

    [Test]
    public async Task FullCdrRequestLifecycle_Succeeds()
    {
        SkipIfNotIntegrationTest();

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

    [Test]
    public async Task Create_WithMinimalFields_Succeeds()
    {
        SkipIfNotIntegrationTest();

        var id = await CreateCdrRequestAsync();

        try
        {
            await Assert.That(string.IsNullOrEmpty(id)).IsFalse();
        }
        finally
        {
            await CleanupCdrRequestAsync(id);
        }
    }

    [Test]
    public async Task List_ReturnsCreatedRequest()
    {
        SkipIfNotIntegrationTest();

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

    [Test]
    public async Task Get_ExistingCdrRequest_ReturnsCorrectData()
    {
        SkipIfNotIntegrationTest();

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

    [Test]
    public async Task Delete_ExistingCdrRequest_Succeeds()
    {
        SkipIfNotIntegrationTest();

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
            CallTypes = new List<CallType> { CallType.Inbound },
            RecordTypes = new List<RecordType> { RecordType.Complete },
            Connections = new List<string> { "conn_1234567890" },
            ReportName = "TestReport_" + Guid.NewGuid(),
            Source = "calls"
        };

        var resp = await Client.V1
            .CdrRequests
            .Create(req, CancellationToken.None);

        await Assert.That(resp).IsNotNull();
        await Assert.That(string.IsNullOrEmpty(resp.Id)).IsFalse();
        return resp.Id;
    }

    private async Task ListCdrRequestsAsync(string expectedId)
    {
        var req = new ListCdrRequestsRequest { PageSize = 10 };
        var list = await Client
            .V1
            .CdrRequests
            .List(req, CancellationToken.None);

        await Assert.That(list).IsNotNull();
        await Assert.That(list.Any(r => r.Id == expectedId)).IsTrue();
    }

    private async Task GetCdrRequestAsync(string id)
    {
        var resp = await Client
            .V1
            .CdrRequests
            .Get(id, CancellationToken.None);

        await Assert.That(resp).IsNotNull();
        await Assert.That(resp.Id).IsEqualTo(id);
    }

    private async Task DeleteCdrRequestAsync(string id)
    {
        var resp = await Client
            .V1
            .CdrRequests
            .Delete(id, CancellationToken.None);

        await Assert.That(resp).IsNotNull();
        await Assert.That(resp.Success).IsTrue();
    }

    private async Task CleanupCdrRequestAsync(string id)
    {
        if (!string.IsNullOrEmpty(id))
        {
            try
            {
                await Client.V1.CdrRequests.Delete(id, CancellationToken.None);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to delete CDR Request {id} during cleanup: {ex.Message}");
            }
        }
    }

}