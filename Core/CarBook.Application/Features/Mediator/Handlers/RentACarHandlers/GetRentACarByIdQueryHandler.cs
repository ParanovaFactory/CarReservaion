using CarBook.Application.Features.Mediator.Queries.RentACarQueries;
using CarBook.Application.Features.Mediator.Results.RentACarResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarByIdQueryHandler : IRequestHandler<GetRentACarByIdQuery, GetRentACarByIdQueryResult>
    {
        private readonly IRepository<RentACar> _rentACarRepository;

        public GetRentACarByIdQueryHandler(IRepository<RentACar> rentACarRepository)
        {
            _rentACarRepository = rentACarRepository;
        }

        public async Task<GetRentACarByIdQueryResult> Handle(GetRentACarByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _rentACarRepository.GetByIdAsync(request.id);
            return new GetRentACarByIdQueryResult
            {
                RentACarId = value.RentACarId,
                PickUpLocationId = value.PickUpLocationId,
                Available = value.Available,
                RentACarCarId = value.RentACarCarId
            };
        }
    }
}
