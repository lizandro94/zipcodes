using Moq;
using Shouldly;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Zipcodes.Application.Contracts;
using Zipcodes.Application.Features.PostalRecords.Queries.GetPostalRecords;
using Zipcodes.Application.UnitTests.Mocks;

namespace Zipcodes.Application.UnitTests.PostalRecords.Queries
{
    public class GetPostalRecordListQueryHandlerTest
    {
        private readonly Mock<IHtmlPackService> _mockHtmlPackService;

        public GetPostalRecordListQueryHandlerTest()
        {
            _mockHtmlPackService = ServiceMocks.GetHtmlPackService();
        }

        [Fact]
        public async Task GetPostalRecordsListTest()
        {
            var handler = new GetPostalRecordListQueryHandler(_mockHtmlPackService.Object);

            var result = await handler.Handle(new GetPostalRecordListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<PostalRecordListVM>>();
            result.Count.ShouldBe(4);
        }
    }
}
