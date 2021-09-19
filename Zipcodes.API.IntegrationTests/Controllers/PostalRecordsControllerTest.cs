using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Zipcodes.Api;
using Zipcodes.API.IntegrationTests.Base;
using Zipcodes.Application.Features.PostalRecords.Queries.GetPostalRecords;

namespace Zipcodes.API.IntegrationTests.Controllers
{
    public class PostalRecordsControllerTest : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public PostalRecordsControllerTest(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ReturnsSuccessResult()
        {
            var client = _factory.GetAnonymousClient();

            var response = await client.GetAsync("/postal/records");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<PostalRecordListVM>>(responseString);

            Assert.IsType<List<PostalRecordListVM>>(result);
            Assert.NotEmpty(result);
        }
    }
}
