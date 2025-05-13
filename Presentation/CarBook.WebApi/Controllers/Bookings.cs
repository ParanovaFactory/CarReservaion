using CarBook.Application.Features.Mediator.Commands.BookingCommands;
using CarBook.Application.Features.Mediator.Queries.BookingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Bookings : ControllerBase
    {
        private readonly IMediator _mediator;

        public Bookings(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            var query = new GetBookingQuery();
            var booking = await _mediator.Send(query);
            return Ok(booking);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookingById(int id)
        {
            var query = new GetBookingByIdQuery(id);
            var booking = await _mediator.Send(query);
            return Ok(booking);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Booking was added");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var command = new DeleteBookingCommand(id);
            await _mediator.Send(command);
            return Ok("Booking was deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBooking(UpdateBookingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Booking was updated");
        }
    }
}
