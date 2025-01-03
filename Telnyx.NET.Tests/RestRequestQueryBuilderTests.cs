using RestSharp;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Tests
{
    public class RestRequestQueryBuilderTests
    {
        private readonly RestRequest _sut;

        public RestRequestQueryBuilderTests()
        {
            _sut = new RestRequest();
        }

        private enum TestStatus
        {
            [JsonPropertyName("active_status")]
            Active,
            [JsonPropertyName("inactive_status")]
            Inactive
        }

        [Fact]
        public void AddFilter_WhenGivenEnum_UsesJsonPropertyName()
        {
            var request = _sut.AddFilter("status", TestStatus.Active);
            var parameter = request.Parameters.First();

            Assert.Equal("status", parameter.Name);
            Assert.Equal("active_status", parameter.Value);
            Assert.Equal(ParameterType.QueryString, parameter.Type);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddFilter_WhenGivenNullOrEmpty_AddsNoParameter(string value)
        {
            var request = _sut.AddFilter("key", value);
            Assert.Empty(request.Parameters);
        }

        [Fact]
        public void AddFilter_WhenGivenSpecialCharacters_AddsParameter()
        {
            var request = _sut.AddFilter("name", "value");
            var parameter = request.Parameters.First();

            Assert.Equal("name", parameter.Name);
            Assert.Equal("value", parameter.Value);
            Assert.Equal(ParameterType.QueryString, parameter.Type);
        }

        [Fact]
        public void AddFilterList_WhenGivenMultipleValues_AddsArrayParameters()
        {
            var values = new List<string> { "one", "two", "three" };
            var request = _sut.AddFilterList("items", values);
            var parameters = request.Parameters.ToList();

            Assert.Equal(2, parameters.Count);
            Assert.Equal("items[]", parameters[0].Name);
            Assert.Equal("one", parameters[0].Value);
            Assert.Equal("items[]", parameters[1].Name);
            Assert.Equal("two", parameters[1].Value);
            Assert.Equal("items[]", parameters[2].Name);
            Assert.Equal("three", parameters[2].Value);
            Assert.All(parameters, p => Assert.Equal(ParameterType.QueryString, p.Type));
        }

        [Theory]
        [InlineData(10, 10)]
        [InlineData(300, 250)]
        [InlineData(null, 50)]
        public void AddPagination_AppliesCorrectLimits(int? pageSize, int expectedSize)
        {
            var request = _sut.AddPagination(pageSize);
            var parameters = request.Parameters.ToList();

            Assert.Equal(2, parameters.Count);
            Assert.Contains(parameters, p => p.Name == "page[size]" && (int)p.Value == expectedSize);
            Assert.Contains(parameters, p => p.Name == "page[number]" && (int)p.Value == 1);
            Assert.All(parameters, p => Assert.Equal(ParameterType.QueryString, p.Type));
        }

        [Fact]
        public void QueryBuilder_WhenCombiningMultipleFilters_AddsAllParameters()
        {
            var request = _sut
                .AddFilter("status", TestStatus.Active)
                .AddFilter("type", "customer")
                .AddFilterList("tags", new List<string> { "new", "vip" })
                .AddPagination(50);

            var parameters = request.Parameters.ToList();

            Assert.Equal(6, parameters.Count);
            Assert.All(parameters, p => Assert.Equal(ParameterType.QueryString, p.Type));
            Assert.Contains(parameters, p => p.Name == "status" && p.Value.ToString() == "active_status");
            Assert.Contains(parameters, p => p.Name == "type" && p.Value.ToString() == "customer");
            Assert.Contains(parameters, p => p.Name == "tags[]" && p.Value.ToString() == "new");
            Assert.Contains(parameters, p => p.Name == "tags[]" && p.Value.ToString() == "vip");
            Assert.Contains(parameters, p => p.Name == "page[size]" && (int)p.Value == 50);
            Assert.Contains(parameters, p => p.Name == "page[number]" && (int)p.Value == 1);
        }
    }
}