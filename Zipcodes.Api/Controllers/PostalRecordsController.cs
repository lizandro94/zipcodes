using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zipcodes.Application.Features.PostalRecords.Queries.GetPostalRecords;

namespace Zipcodes.Api.Controllers
{
    [Route("postal/records")]
    [ApiController]
    public class PostalRecordsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostalRecordsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("", Name = "GetAllPostalRecords")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<PostalRecordListVM>>> GetPostalRecords()
        {
            var dtos = await _mediator.Send(new GetPostalRecordListQuery());
            return Ok(dtos);
        }
    }
}
