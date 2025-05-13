using CarBook.Application.Features.Mediator.Queries.AppUserQueries;
using CarBook.Application.Tools;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Logins : ControllerBase
    {
        private readonly IMediator _mediator;

        public Logins(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Index(GetCheckAppUserQuery query)
        {
            var result = await _mediator.Send(query);
            if (result.IsExist)
            {
                return Created("",JwtTokenGenerator.GenerateToken(result));
            }
            return BadRequest("Username or Password Wrong");
        }
    }
}
