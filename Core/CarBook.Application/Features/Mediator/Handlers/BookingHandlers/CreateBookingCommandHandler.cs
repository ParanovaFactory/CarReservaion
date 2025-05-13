using CarBook.Application.Features.Mediator.Commands.BookingCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BookingHandlers
{
    public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand>
    {
        private readonly IRepository<Booking> _bookingRepository;

        public CreateBookingCommandHandler(IRepository<Booking> bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            await _bookingRepository.CreateAsync( new Booking
            {
                Age = request.Age,
                BookingCarId = request.CarId,
                Description = request.Description,
                DriverLicense = request.DriverLicense,
                DropOffLocationId = request.DropOffLocationId,
                Email = request.Email,
                Name = request.Name,
                Phone = request.Phone,
                PickUpLocationId = request.PickUpLocationId,
                Surname = request.Surname,
                Status = "Pending"
            });
        }
    }
}
