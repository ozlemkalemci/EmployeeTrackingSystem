using Application.Common.Features.Addresses.Command.Add;
using Application.Common.Features.Employees.Command.Add;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add-address")]
        public async Task<IActionResult> AddAddressAsync(AddAddressCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
