using Application.Common.Features.PhoneNumbers.Command.Add;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PhoneController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add-phone-numbers")]
        public async Task<IActionResult> AddPhoneNumbersAsync(AddPhoneNumbersCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
