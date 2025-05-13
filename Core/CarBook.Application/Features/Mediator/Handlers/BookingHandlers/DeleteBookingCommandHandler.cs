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
    public class DeleteBookingCommandHandler : IRequestHandler<DeleteBookingCommand>
    {
        private readonly IRepository<Booking> _bookingRepository;

        public DeleteBookingCommandHandler(IRepository<Booking> bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task Handle(DeleteBookingCommand request, CancellationToken cancellationToken)
        {
            var value = await _bookingRepository.GetByIdAsync(request.id);
            _bookingRepository.RemoveAsync(value);
        }
    }
}
