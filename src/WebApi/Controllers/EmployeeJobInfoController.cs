using Application.Common.Features.EmployeeJobInformation.Command.Add;
using MediatR;
using Microsoft.AspNetCore.Http;
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
    }
}
