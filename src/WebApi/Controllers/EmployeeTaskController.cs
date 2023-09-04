using Application.Common.Features.EmployeeTasks.Command.Add;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTaskController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeTaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add-employee-task")]
        public async Task<IActionResult> AddEmployeeTaskAsync(AddEmployeeTaskCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
