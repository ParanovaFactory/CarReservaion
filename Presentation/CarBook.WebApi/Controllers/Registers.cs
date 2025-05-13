using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.AppUserCommands;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Registers : ControllerBase
    {
        private readonly IMediator _mediator;

        public Registers(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> SingUp(CreateAppUserCommand command)
        {
            await _mediator.Send(command);
            return BadRequest("User was added");
        }
    }
}
