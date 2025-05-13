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
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRepository<RentACar> _rentACarRepository;

        public GetRentACarQueryHandler(IRepository<RentACar> rentACarRepository)
        {
            _rentACarRepository = rentACarRepository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _rentACarRepository.GetAllAsync();
            return values.Select(x => new GetRentACarQueryResult
            {
                RentACarId = x.RentACarId,
                PickUpLocationId = x.PickUpLocationId,
                Available = x.Available,
                RentACarCarId = x.RentACarCarId
            }).ToList();
        }
    }
}
