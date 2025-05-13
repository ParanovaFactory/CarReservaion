using CarBook.Application.Features.Mediator.Commands.CarDescriptionCommands;
using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDescription : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarDescription(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetCarDescriptionQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetCarDescriptionByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCarDescriptionCommand command)
        {
            await _mediator.Send(command);
            return Ok("Car Description was created");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCarDescriptionCommand command)
        {
            await _mediator.Send(command);
            return Ok("Car Description was updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteCarDescriptionCommand(id);
            await _mediator.Send(command);
            return Ok("Car Description was deleted");
        }

        [HttpGet("GetCarDescriptionByCarId/{id}")]
        public async Task<IActionResult> GetCarDescriptionByCarId(int id)
        {
            var query = new GetCarDescriptionByCarIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
