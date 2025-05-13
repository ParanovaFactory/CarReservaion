using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
            {
                CarBrandId = x.CarBrandId,
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
