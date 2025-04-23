using TelnyxSharp.DetailRecords.Models.Requests;
using TelnyxSharp.DetailRecords.Models.Responses;
using TelnyxSharp.Enums;
using TelnyxSharp.Tests;

public class DetailRecordsOperationsTests : TelnyxTestBase
{
    [Fact]
    public async Task Search_WithMinimalParams_ReturnsResults()
    {
        // Arrange
        var request = new DetailRecordSearchRequest
        {
            RecordType = DetailRecordType.Messaging,
            PageSize = 10
        };

        // Act
        var response = await Client.DetailRecordsSearch.Search(request);

        // Assert
        Assert.NotNull(response);
        Assert.NotEmpty(response.Data);
        Assert.NotNull(response.Meta);
        Assert.InRange(response.Meta.PageNumber, 1, int.MaxValue);
        Assert.InRange(response.Meta.PageSize, 1, 50);

        Assert.All(response.Data, record =>
        {
            var msg = Assert.IsType<MessageDetailRecord>(record);
            Assert.NotNull(msg.Uuid);
            Assert.NotNull(msg.Status);
            Assert.NotNull(msg.Cld);
            Assert.NotNull(msg.Cli);
            Assert.NotEqual(default, msg.CreatedAt);
        });
    }

    [Fact]
    public async Task Search_WithFilters_ReturnsFilteredResults()
    {
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
        Assert.NotNull(response);
        Assert.All(response.Data, record =>
        {
            var msg = Assert.IsType<MessageDetailRecord>(record);
            Assert.Equal("delivered", msg.Status);
            Assert.True(msg.CreatedAt >= startTime);
        });
    }

    [Fact]
    public async Task Search_WithPagination_WorksCorrectly()
    {
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

        Assert.NotNull(firstPage);
        Assert.NotNull(secondPage);
        Assert.NotEmpty(firstPage.Data);
        Assert.NotEmpty(secondPage.Data);
        
        Assert.Equal(1, firstPage.Meta.PageNumber);
        Assert.Equal(2, secondPage.Meta.PageNumber);
        Assert.Equal(5, firstPage.Meta.PageSize);
        Assert.Equal(5, secondPage.Meta.PageSize);

        var firstPageIds = firstPage.Data.Cast<MessageDetailRecord>().Select(d => d.Uuid);
        var secondPageIds = secondPage.Data.Cast<MessageDetailRecord>().Select(d => d.Uuid);
        Assert.Empty(firstPageIds.Intersect(secondPageIds));
    }
}