using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Inrfefaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarByIdWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdWithBrandQueryResult> Handle(GetCarByIdWithBrandQuery query)
        {
            var value = _repository.GetCarByIdWithBrand(query.id);

            return new GetCarByIdWithBrandQueryResult
            {
                CarBrandId = value.CarBrandId,
                CarBrandName = value.Brand.BrandName,
                CarBigImageUrl = value.CarBigImageUrl,
                CarCoverImageUrl = value.CarCoverImageUrl,
                CarFuel = value.CarFuel,
                CarId = value.CarId,
                CarKilometer = value.CarKilometer,
                CarLuggage = value.CarLuggage,
                CarModel = value.CarModel,
                CarSeats = value.CarSeats,
                CarTransmission = value.CarTransmission
            };
        }
    }
}
