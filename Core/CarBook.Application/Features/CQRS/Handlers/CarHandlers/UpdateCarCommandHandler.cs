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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var car = await _repository.GetByIdAsync(command.CarId);
            car.CarBrandId = command.CarBrandId;
            car.CarBigImageUrl = command.CarBigImageUrl;
            car.CarCoverImageUrl = command.CarCoverImageUrl;
            car.CarFuel = command.CarFuel;
            car.CarKilometer = command.CarKilometer;
            car.CarLuggage = command.CarLuggage;
            car.CarModel = command.CarModel;
            car.CarSeats = command.CarSeats;
            car.CarTransmission = command.CarTransmission;
            await _repository.UpdateAsync(car);
        }
    }
}
