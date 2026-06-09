using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace TelnyxSharp.Tests
{
    public sealed class RestRequestQueryBuilderTests
    {
        private readonly TelnyxRequest _sut = new("");

        [JsonConverter(typeof(JsonStringEnumConverter))]
        private enum TestStatus
        {
            [JsonStringEnumMemberName("active_status")]
            Active,

            [JsonStringEnumMemberName("inactive_status")]
            Inactive
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        private enum PlainEnum
        {
            First,
            Second,
            Third
        }

        private static string GetQueryString(TelnyxRequest request)
        {
            var parameters = request.Parameters
                .Where(p => p.Type == ParameterType.QueryString)
                .OrderBy(p => p.Name)
                .Select(p => $"{p.Name}={p.Value?.ToString()}");

            return string.Join("&", parameters);
        }

        [Test]
        public async Task AddFilter_WithEnum_GeneratesCorrectQueryString()
        {
            var request = _sut.AddFilter("status", TestStatus.Active);
            await Assert.That(GetQueryString(request)).IsEqualTo("status=active_status");
        }

        [Test]
        public async Task AddFilter_WithPlainEnum_GeneratesCorrectQueryString()
        {
            var request = _sut.AddFilter("level", PlainEnum.First);
            await Assert.That(GetQueryString(request)).IsEqualTo("level=First");
        }

        [Test]
        public async Task AddFilter_WithNullEnum_GeneratesEmptyQueryString()
        {
            var request = _sut.AddFilter("status", null as TestStatus?);
            await Assert.That(GetQueryString(request)).IsEqualTo("");
        }

        [Test]
        [Arguments(null)]
        [Arguments("")]
        [Arguments(" ")]
        [Arguments("   ")]
        [Arguments("\t")]
        [Arguments("\n")]
        [Arguments("\r\n")]
        public async Task AddFilter_WithNullOrWhitespace_GeneratesEmptyQueryString(string? value)
        {
            var request = _sut.AddFilter("key", value);
            await Assert.That(GetQueryString(request)).IsEqualTo("");
        }

        [Test]
        [Arguments("simple", "value", "simple=value")]
        [Arguments("key with space", "value with space", "key with space=value with space")]
        [Arguments("key", "!@#$%", "key=!@#$%")]
        [Arguments("key", "value&more", "key=value&more")]
        [Arguments("key", " value ", "key= value ")] // Preserves meaningful whitespace
        public async Task AddFilter_WithValidString_GeneratesCorrectQueryString(string key, string value, string expected)
        {
            var request = _sut.AddFilter(key, value);
            await Assert.That(GetQueryString(request)).IsEqualTo(expected);
        }

        [Test]
        public async Task AddFilterList_WithNullList_GeneratesEmptyQueryString()
        {
            var request = _sut.AddFilterList("tags", null);
            await Assert.That(GetQueryString(request)).IsEqualTo("");
        }

        [Test]
        public async Task AddFilterList_WithEmptyList_GeneratesEmptyQueryString()
        {
            var request = _sut.AddFilterList("tags", new List<string>());
            await Assert.That(GetQueryString(request)).IsEqualTo("");
        }

        [Test]
        public async Task AddFilterList_WithValues_GeneratesArrayStyleQueryString()
        {
            var values = new List<string> { "one", "two", "three" };
            var request = _sut.AddFilterList("items", values);
            await Assert.That(GetQueryString(request)).IsEqualTo("items[]=one&items[]=two&items[]=three");
        }

        [Test]
        public async Task AddFilterList_WithMixedValues_FiltersOutInvalidValues()
        {
            var values = new List<string> { "valid", "", null!, "also-valid", " ", "\t", "  valid-too  " };
            var request = _sut.AddFilterList("tags", values);
            await Assert.That(GetQueryString(request)).IsEqualTo("tags[]=valid&tags[]=also-valid&tags[]=  valid-too  ");
        }

        [Test]
        [Arguments(10, "page[number]=1&page[size]=10")]
        [Arguments(0, "page[number]=1&page[size]=1")]    // Below minimum
        [Arguments(-1, "page[number]=1&page[size]=1")]   // Below minimum
        [Arguments(300, "page[number]=1&page[size]=250")] // Above maximum
        [Arguments(null, "page[number]=1&page[size]=50")] // Default value
        public async Task AddPagination_GeneratesCorrectQueryString(int? pageSize, string expected)
        {
            var request = _sut.AddPagination(pageSize);
            await Assert.That(GetQueryString(request)).IsEqualTo(expected);
        }

        [Test]
        public async Task QueryBuilder_CombiningMultipleFilters_GeneratesCorrectQueryString()
        {
            var request = _sut
                .AddFilter("status", TestStatus.Active)
                .AddFilter("type", "customer")
                .AddFilterList("tags", new List<string> { "new", "vip" })
                .AddPagination(50);

            var queryString = GetQueryString(request);
            await Assert.That(queryString).IsEqualTo("page[number]=1&page[size]=50&status=active_status&tags[]=new&tags[]=vip&type=customer");
        }

        [Test]
        public async Task QueryBuilder_WithSpecialCharacters_GeneratesCorrectQueryString()
        {
            var request = _sut.AddFilter("complex", "Hello & World!")
                            .AddFilterList("tags", new List<string> { "tag&value", "special!char" });

            await Assert.That(GetQueryString(request)).IsEqualTo("complex=Hello & World!&tags[]=tag&value&tags[]=special!char");
        }


        [Test]
        public async Task AddFilter_WithOperator_GeneratesCorrectQueryString()
        {
            var request = _sut.AddFilter("filter[created_at]", "2023-01-01", FilterOperator.StartsWith);
            await Assert.That(GetQueryString(request)).IsEqualTo("filter[created_at][starts_with]=2023-01-01");
        }

        [Test]
        public async Task AddFilter_WithEnumAndOperator_GeneratesCorrectQueryString()
        {
            var request = _sut.AddFilter("filter[status]", TestStatus.Active, FilterOperator.Equals);
            await Assert.That(GetQueryString(request)).IsEqualTo("filter[status][eq]=active_status");
        }

        [Test]
        public async Task AddFilter_WithPreformattedKeyAndOperator_AppendsOperatorCorrectly()
        {
            var request = _sut.AddFilter("custom_key", "value", FilterOperator.Contains);
            await Assert.That(GetQueryString(request)).IsEqualTo("custom_key[contains]=value");
        }

        [Test]
        public async Task AddFilter_WithMultipleOperators_GeneratesDistinctParameters()
        {
            var request = _sut
                .AddFilter("filter[created_at]", "2023-01-01", FilterOperator.GreaterThanOrEqualTo)
                .AddFilter("filter[created_at]", "2023-12-31", FilterOperator.LessThanOrEqualTo);
            await Assert.That(GetQueryString(request)).IsEqualTo("filter[created_at][gte]=2023-01-01&filter[created_at][lte]=2023-12-31");
        }

        [Test]
        public async Task AddFilter_WithComplexFilterChain_GeneratesCorrectQueryString()
        {
            var request = _sut
                .AddFilter("filter[record_type]", DetailRecordType.Conference)
                .AddFilter("filter[direction]", "inbound")
                .AddFilter("filter[created_at]", "2023-01-01", FilterOperator.GreaterThanOrEqualTo)
                .AddFilter("filter[created_at]", "2023-12-31", FilterOperator.LessThanOrEqualTo)
                .AddFilter("filter[status]", TestStatus.Active)
                .AddFilter("sort", "created_at");

            await Assert.That(GetQueryString(request)).IsEqualTo("filter[created_at][gte]=2023-01-01&filter[created_at][lte]=2023-12-31&filter[direction]=inbound&filter[record_type]=conference&filter[status]=active_status&sort=created_at");
        }

        [Test]
        public async Task AddFilter_MultipleConditionsForSameField_GeneratesCorrectQueryString()
        {
            var request = _sut
                .AddFilter("filter[started_at]", "2022-02-02", FilterOperator.GreaterThan)
                .AddFilter("filter[started_at]", "2022-03-01", FilterOperator.LessThan);

            await Assert.That(GetQueryString(request)).IsEqualTo("filter[started_at][gt]=2022-02-02&filter[started_at][lt]=2022-03-01");
        }
    }
}
