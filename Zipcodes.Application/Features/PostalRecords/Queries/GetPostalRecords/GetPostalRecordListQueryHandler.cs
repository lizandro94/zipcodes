using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Zipcodes.Application.Contracts;

namespace Zipcodes.Application.Features.PostalRecords.Queries.GetPostalRecords
{
    public class GetPostalRecordListQueryHandler : IRequestHandler<GetPostalRecordListQuery, List<PostalRecordListVM>>
    {
        private readonly IHtmlPackService _htmlPackService;

        public GetPostalRecordListQueryHandler(IHtmlPackService htmlPackService)
        {
            _htmlPackService = htmlPackService;
        }
        public async Task<List<PostalRecordListVM>> Handle(GetPostalRecordListQuery request, CancellationToken cancellationToken)
        {
            var postalRecords = await _htmlPackService.GetPostalRecords();
            var mappedPostalRecords = postalRecords.Select(r => new PostalRecordListVM
            {
                Department = r.Department,
                Municipality = r.Municipality,
                Zipcode = r.Zipcode,
                Neighbourhood = r.Neighbourhood
            });

            return mappedPostalRecords.ToList();
        }
    }
}
