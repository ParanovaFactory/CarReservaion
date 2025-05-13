using CarBook.Application.Features.CQRS.Commends.CarCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                CarBrandId = command.CarBrandId,
                CarBigImageUrl = command.CarBigImageUrl,
                CarCoverImageUrl = command.CarCoverImageUrl,
                CarFuel = command.CarFuel,
                CarKilometer = command.CarKilometer,
                CarLuggage = command.CarLuggage,
                CarModel = command.CarModel,
                CarSeats = command.CarSeats,
                CarTransmission = command.CarTransmission
            });
        }
    }
}
