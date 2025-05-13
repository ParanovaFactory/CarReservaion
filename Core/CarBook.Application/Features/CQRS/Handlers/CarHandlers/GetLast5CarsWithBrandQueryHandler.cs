using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Inrfefaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetLast5CarsWithBrandQueryResult> Handle()
        {
            var values = _repository.GetLast5CarsWithBrand();
            return values.Select(x => new GetLast5CarsWithBrandQueryResult
            {
                CarBrandId = x.CarBrandId,
                CarBrandName = x.Brand.BrandName,
                CarBigImageUrl = x.CarBigImageUrl,
                CarCoverImageUrl = x.CarCoverImageUrl,
                CarFuel = x.CarFuel,
                CarId = x.CarId,
                CarKilometer = x.CarKilometer,
                CarLuggage = x.CarLuggage,
                CarModel = x.CarModel,
                CarSeats = x.CarSeats,
                CarTransmission = x.CarTransmission
            }).ToList();
        }
    }
}
