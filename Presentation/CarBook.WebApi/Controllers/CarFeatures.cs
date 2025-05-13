using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeatures : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarFeatures(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetCarFeatureQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetCarFeatureByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCarFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Car Feature was created");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCarFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Car Feature was updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteCarFeatureCommand(id);
            await _mediator.Send(command);
            return Ok("Car Feature was deleted");
        }

        [HttpGet("GetCarFeatureByCarId/{id}")]
        public async Task<IActionResult> GetCarFeatureByCarId(int id)
        {
            var query = new GetCarFeatureByCarQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("ChangeCarFeatureAvilebleToTrue")]
        public async Task<IActionResult> ChangeCarFeatureAvilebleToTrue(int id)
        {
            var command = new ChangeCarFeatureAvilebleToTrueCommand(id);
            await _mediator.Send(command);
            return Ok("Car Feature was set to available");
        }

        [HttpGet("ChangeCarFeatureAvilebleToFalse")]
        public async Task<IActionResult> ChangeCarFeatureAvilebleToFalse(int id)
        {
            var command = new ChangeCarFeatureAvilebleToFalseCommand(id);
            await _mediator.Send(command);
            return Ok("Car Feature was set to unavailable");
        }
    }
}
