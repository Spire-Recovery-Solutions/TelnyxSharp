using TelnyxSharp.DetailRecords.Models.Requests;
using TelnyxSharp.DetailRecords.Models.Responses;
using TelnyxSharp.Enums;
using TelnyxSharp.Tests;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

public sealed class DetailRecordsOperationsTests : TelnyxTestBase
{
    [Test]
    public async Task Search_WithMinimalParams_ReturnsResults()
    {
        SkipIfNotIntegrationTest();

        // Arrange
        var request = new DetailRecordSearchRequest
        {
            RecordType = DetailRecordType.Messaging,
            PageSize = 10
        };

        // Act
        var response = await Client.DetailRecordsSearch.Search(request);

        // Assert
        await Assert.That(response).IsNotNull();
        await Assert.That(response.Data).IsNotEmpty();
        await Assert.That(response.Meta).IsNotNull();
        await Assert.That(response.Meta.PageNumber).IsGreaterThanOrEqualTo(1);
        await Assert.That(response.Meta.PageSize).IsBetween(1, 50);

        foreach (var record in response.Data)
        {
            await Assert.That(record).IsTypeOf<MessageDetailRecord>();
            var msg = (MessageDetailRecord)record;
            await Assert.That(msg.Uuid).IsNotNull();
            await Assert.That(msg.Status).IsNotNull();
            await Assert.That(msg.Cld).IsNotNull();
            await Assert.That(msg.Cli).IsNotNull();
            await Assert.That(msg.CreatedAt).IsNotEqualTo(default);
        }
    }

    [Test]
    public async Task Search_WithFilters_ReturnsFilteredResults()
    {
        SkipIfNotIntegrationTest();

        // Arrange
        var startTime = DateTime.UtcNow.AddDays(-1);
        var request = new DetailRecordSearchRequest
        {
            RecordType = DetailRecordType.Messaging,
            PageSize = 10,
            Filters = new List<FilterCriteria>
            {
                new FilterCriteria
                {
                    Field = "status",
                    Operator = FilterOperator.Equals,
                    Value = "delivered"
                },
                new FilterCriteria
                {
                    Field = "created_at",
                    Operator = FilterOperator.GreaterThanOrEqualTo,
                    Value = startTime.ToString("o")
                }
            }
        };

        // Act
        var response = await Client.DetailRecordsSearch.Search(request);

        // Assert
        await Assert.That(response).IsNotNull();
        foreach (var record in response.Data)
        {
            await Assert.That(record).IsTypeOf<MessageDetailRecord>();
            var msg = (MessageDetailRecord)record;
            await Assert.That(msg.Status).IsEqualTo("delivered");
            await Assert.That(msg.CreatedAt >= startTime).IsTrue();
        }
    }

    [Test]
    public async Task Search_WithPagination_WorksCorrectly()
    {
        SkipIfNotIntegrationTest();

        // Arrange
        var firstPageRequest = new DetailRecordSearchRequest
        {
            RecordType = DetailRecordType.Messaging,
            PageNumber = 1,
            PageSize = 5
        };

        var secondPageRequest = new DetailRecordSearchRequest
        {
            RecordType = DetailRecordType.Messaging,
            PageNumber = 2,
            PageSize = 5
        };

        // Act
        var firstPage = await Client.DetailRecordsSearch.Search(firstPageRequest);
        var secondPage = await Client.DetailRecordsSearch.Search(secondPageRequest);

        await Assert.That(firstPage).IsNotNull();
        await Assert.That(secondPage).IsNotNull();
        await Assert.That(firstPage.Data).IsNotEmpty();
        await Assert.That(secondPage.Data).IsNotEmpty();

        await Assert.That(firstPage.Meta.PageNumber).IsEqualTo(1);
        await Assert.That(secondPage.Meta.PageNumber).IsEqualTo(2);
        await Assert.That(firstPage.Meta.PageSize).IsEqualTo(5);
        await Assert.That(secondPage.Meta.PageSize).IsEqualTo(5);

        var firstPageIds = firstPage.Data.Cast<MessageDetailRecord>().Select(d => d.Uuid);
        var secondPageIds = secondPage.Data.Cast<MessageDetailRecord>().Select(d => d.Uuid);
        await Assert.That(firstPageIds.Intersect(secondPageIds)).IsEmpty();
    }
}
