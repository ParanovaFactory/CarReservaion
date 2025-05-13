using CarBook.Application.Features.Mediator.Commands.CarDescriptionCommands;
using CarBook.Application.Features.Mediator.Commands.CarReviewCommands;
using CarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
using CarBook.Application.Features.Mediator.Queries.CarReviewQuries;
using CarBook.Application.Validators.ReviewValidators;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarReviews : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarReviews(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetCarReviewQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetCarReviewByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCarReviewCommand command)
        {
            CreateReviewValidator validator = new CreateReviewValidator();
            var validationResult = await validator.ValidateAsync(command);
            if (!validationResult.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _mediator.Send(command);
            return Ok("Car Review was created");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCarReviewCommand command)
        {
            UpdateReviewValidator validator = new UpdateReviewValidator();
            var validationResult = await validator.ValidateAsync(command);
            if (!validationResult.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _mediator.Send(command);
            return Ok("Car Review was updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteCarReviewCommand(id);
            await _mediator.Send(command);
            return Ok("Car Review was deleted");
        }

        [HttpGet("GetCarReviewWithCar/{id}")]
        public async Task<IActionResult> GetCarReviewWithCar(int id)
        {
            var query = new GetCarReviewByCarIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
