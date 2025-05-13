using CarBook.Application.Features.Mediator.Queries.RentACarQueries;
using CarBook.Application.Features.Mediator.Results.RentACarResults;
using CarBook.Application.Interfaces.RentACarInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetFilteredRentACarQueryHandler : IRequestHandler<GetFilteredRentACarQuery, List<GetFilteredRentACarQueryResult>>
    {
        private readonly IRentACarInterface _rentACarInterface;

        public GetFilteredRentACarQueryHandler(IRentACarInterface rentACarInterface)
        {
            _rentACarInterface = rentACarInterface;
        }

        public async Task<List<GetFilteredRentACarQueryResult>> Handle(GetFilteredRentACarQuery request, CancellationToken cancellationToken)
        {
            var value = await _rentACarInterface.GetByFilterAsync(x=>x.PickUpLocationId == request.PickUpLocationId && x.Available == true);
            return value.Select(x => new GetFilteredRentACarQueryResult
            {
                RentACarId = x.RentACarId,
                BrandName = x.Car.Brand.BrandName,
                CarCoverImageUrl = x.Car.CarCoverImageUrl,
                CarModel = x.Car.CarModel,
                RentACarCarId = x.RentACarCarId,
            }).ToList();
        }
    }
}
