using CarBook.Application.Features.Mediator.Queries.BookingQueries;
using CarBook.Application.Features.Mediator.Results.BookingResults;
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
    public class GetBookingByIdQueryHandler : IRequestHandler<GetBookingByIdQuery, GetBookingByIdQueryResult>
    {
        private readonly IRepository<Booking> _bookingRepository;

        public GetBookingByIdQueryHandler(IRepository<Booking> bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<GetBookingByIdQueryResult> Handle(GetBookingByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _bookingRepository.GetByIdAsync(request.id);
            return new GetBookingByIdQueryResult
            {
                Age = value.Age,
                BookingCarId = value.BookingCarId,
                Description = value.Description,
                DriverLicense = value.DriverLicense,
                DropOffLocationId = value.DropOffLocationId,
                Email = value.Email,
                Name = value.Name,
                Phone = value.Phone,
                PickUpLocationId = value.PickUpLocationId,
                Surname = value.Surname
            };
        }
    }
}
