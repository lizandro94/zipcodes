using MediatR;
using System.Collections.Generic;

namespace Zipcodes.Application.Features.PostalRecords.Queries.GetPostalRecords
{
    public class GetPostalRecordListQuery : IRequest<List<PostalRecordListVM>>
    {
    }
}
