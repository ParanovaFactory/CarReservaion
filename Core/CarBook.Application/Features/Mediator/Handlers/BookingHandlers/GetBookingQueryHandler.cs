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
    public class GetBookingQueryHandler : IRequestHandler<GetBookingQuery, List<GetBookingQueryResult>>
    {
        private readonly IRepository<Booking> _bookingRepository;

        public GetBookingQueryHandler(IRepository<Booking> bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<List<GetBookingQueryResult>> Handle(GetBookingQuery request, CancellationToken cancellationToken)
        {
            var values = await _bookingRepository.GetAllAsync();
            return values.Select(x => new GetBookingQueryResult
            {
                BookingId = x.BookingId,
                BookingCarId = x.BookingCarId,
                Age = x.Age,
                Description = x.Description,
                DriverLicense = x.DriverLicense,
                Email = x.Email,
                Name = x.Name,
                Phone = x.Phone,
                DropOffLocationId = x.DropOffLocationId,
                PickUpLocationId = x.PickUpLocationId,
                Surname = x.Surname
            }).ToList();
        }
    }
}
