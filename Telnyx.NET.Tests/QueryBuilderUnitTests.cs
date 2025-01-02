using Xunit;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Tests
{
    public class QueryBuilderTests
    {
        // Test data
        public enum TestStatus
        {
            [JsonPropertyName("active_status")]
            Active,
            [JsonPropertyName("inactive_status")]
            Inactive
        }

        public class PaginationTestData : TheoryData<int?, string>
        {
            public PaginationTestData()
            {
                Add(10, "page[size]=10&page[number]=1");
                Add(300, "page[size]=250&page[number]=1");
                Add(null, "page[size]=50&page[number]=1");
            }
        }

        private readonly QueryBuilder _sut;

        public QueryBuilderTests()
        {
            _sut = new QueryBuilder();
        }

        [Fact]
        public void AddFilter_WhenGivenEnum_UsesJsonPropertyName()
        {
            // Act
            var result = _sut.AddFilter("status", TestStatus.Active).ToString();

            // Assert
            Assert.Equal("filter[status]=active_status", result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddFilter_WhenGivenNullOrEmpty_ReturnsEmptyString(string value)
        {
            // Act
            var result = _sut.AddFilter("key", value).ToString();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void AddFilter_WhenGivenSpecialCharacters_UrlEncodesValue()
        {
            // Act
            var result = _sut.AddFilter("name", "test & value").ToString();

            // Assert
            Assert.Equal("filter[name]=test%20%26%20value", result);
        }

        [Fact]
        public void AddFilterList_WhenGivenMultipleValues_AppendsArrayNotation()
        {
            // Arrange
            var values = new[] { "one", "two" };

            // Act
            var result = _sut.AddFilterList("items", values).ToString();

            // Assert
            Assert.Equal("filter[items][]=one&filter[items][]=two", result);
        }

        [Theory]
        [ClassData(typeof(PaginationTestData))]
        public void AddPagination_AppliesCorrectLimits(int? pageSize, string expected)
        {
            // Act
            var result = _sut.AddPagination(pageSize).ToString();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void QueryBuilder_WhenCombiningMultipleFilters_BuildsCorrectQueryString()
        {
            // Act
            var result = _sut
                .AddFilter("status", TestStatus.Active)
                .AddFilter("type", "customer")
                .AddFilterList("tags", new[] { "new", "vip" })
                .AddPagination(25)
                .ToString();

            // Assert
            Assert.Equal(
                "filter[status]=active_status&filter[type]=customer&filter[tags][]=new&filter[tags][]=vip&page[size]=25&page[number]=1",
                result
            );
        }

        [Fact]
        public void ToString_TrimsLeadingAmpersand()
        {
            // Act
            var result = _sut.AddFilter("key", "value").ToString();

            // Assert
            Assert.False(result.StartsWith("&"));
            Assert.StartsWith("filter", result);
        }
    }
}