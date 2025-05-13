using CarBook.Application.Features.Mediator.Commands.RentACarCommands;
using CarBook.Application.Features.Mediator.Queries.RentACarQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACars : ControllerBase
    {
        private readonly IMediator _mediator;

        public RentACars(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("RentACarlist")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetRentACarQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("FilteredCarlist")]
        public async Task<IActionResult> GetFilteredCarList(int locationId, bool available)
        {
            GetFilteredRentACarQuery getFilteredRentACarQuery = new GetFilteredRentACarQuery
            {
                PickUpLocationId = locationId,
                Available = available
            };
            var result = await _mediator.Send(getFilteredRentACarQuery);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetRentACarByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRentACarCommand command)
        {
            await _mediator.Send(command);
            return Ok("RentACar was added");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteRentACarCommand(id);
            await _mediator.Send(command);
            return Ok("RentACar was deleted");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateRentACarCommand command)
        {
            await _mediator.Send(command);
            return Ok("RentACar was updated");
        }
    }
}
