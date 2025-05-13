using CarBook.Application.Features.CQRS.Queries.CarQueries;
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
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.id);

            return new GetCarByIdQueryResult
            {
                CarBrandId = value.CarBrandId,
                CarBigImageUrl= value.CarBigImageUrl,
                CarCoverImageUrl= value.CarCoverImageUrl,
                CarFuel = value.CarFuel,
                CarKilometer = value.CarKilometer,
                CarLuggage = value.CarLuggage,
                CarModel = value.CarModel,
                CarSeats = value.CarSeats,
                CarTransmission = value.CarTransmission
            };
        }
    }
}
