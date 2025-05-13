using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandler
{
    public class CreateCarFeatureCommandHandler : IRequestHandler<CreateCarFeatureCommand>
    {
        private readonly IRepository<CarFeature> _carFeatureRepository;

        public CreateCarFeatureCommandHandler(IRepository<CarFeature> carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task Handle(CreateCarFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = new CarFeature
            {
                CarFeatureFeatureId = request.CarFeatureFeatureId,
                CarFeatureCarId = request.CarFeatureCarId,
                CarFeatureAvaileble = request.CarFeatureAvaileble
            };

            await _carFeatureRepository.CreateAsync(value);
        }
    }
}
