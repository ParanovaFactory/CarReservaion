using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Inrfefaces;
using CarBook.Application.Inrfefaces.CarInterfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values = _repository.GetCarsListWithBrand();
            return values.Select(x => new GetCarWithBrandQueryResult
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
