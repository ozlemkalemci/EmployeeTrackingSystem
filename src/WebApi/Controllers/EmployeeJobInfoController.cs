using Application.Common.Features.EmployeeJobInformation.Command.Add;
using Application.Common.Features.EmployeeJobInformation.Query.GetByEmployeeId;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeJobInfoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeJobInfoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add-employee-job-info")]
        public async Task<IActionResult> AddEmployeeJobInfoAsync(AddEmployeeJobInfoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet("get-job-info-by-employeeid")]
        public async Task<ActionResult<IEnumerable<EmployeeJobInfo>>> GetJobInfoByEmployeeId(Guid employeeId)
        {
            var query = new GetJobInfoByEmployeeIdQuery { EmployeeId = employeeId };
            var jobInfos = await _mediator.Send(query);

            if (jobInfos == null)
            {
                return NotFound();
            }

            return Ok(jobInfos);
        }
    }
}
