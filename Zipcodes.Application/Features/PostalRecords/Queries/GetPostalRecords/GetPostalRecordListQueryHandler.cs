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
        private readonly IPostalRecordRepository _postalRecordRepository;

        public GetPostalRecordListQueryHandler(IPostalRecordRepository postalRecordRepository)
        {
            _postalRecordRepository = postalRecordRepository;
        }
        public async Task<List<PostalRecordListVM>> Handle(GetPostalRecordListQuery request, CancellationToken cancellationToken)
        {
            var postalRecords =  _postalRecordRepository.GetPostalRecords();
            var data = postalRecords.Select(r => new PostalRecordListVM { Department = r.Department });
            return data.ToList();
        }
    }
}
