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
    public class UpdateBookingCommandHandler : IRequestHandler<UpdateBookingCommand>
    {
        private readonly IRepository<Booking> _bookingRepository;

        public UpdateBookingCommandHandler(IRepository<Booking> bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task Handle(UpdateBookingCommand request, CancellationToken cancellationToken)
        {
            var value = await _bookingRepository.GetByIdAsync(request.BookingId);
            value.Age = request.Age;
            value.BookingCarId = request.CarId;
            value.Description = request.Description;
            value.DriverLicense = request.DriverLicense;
            value.DropOffLocationId = request.DropOffLocationId;
            value.Email = request.Email;
            value.Name = request.Name;
            value.Phone = request.Phone;
            value.PickUpLocationId = request.PickUpLocationId;
            value.Surname = request.Surname;
            value.Status = request.Status;
            await _bookingRepository.UpdateAsync(value);
        }
    }
}
