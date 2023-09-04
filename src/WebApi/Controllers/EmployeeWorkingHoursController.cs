using Application.Common.Features.EmployeeWorkingHours.Command.Add;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeWorkingHoursController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeWorkingHoursController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add-employee-working-hours")]
        public async Task<IActionResult> AddEmployeeWorkingHoursAsync(AddEmployeeWorkingHoursCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

    }
}
