using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandler
{
    public class UpdateCarFeatureCommandHandler : IRequestHandler<UpdateCarFeatureCommand>
    {
        private readonly IRepository<CarFeature> _carFeatureRepository;

        public UpdateCarFeatureCommandHandler(IRepository<CarFeature> carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task Handle(UpdateCarFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _carFeatureRepository.GetByIdAsync(request.CarFeatureId);

            value.CarFeatureAvaileble = request.CarFeatureAvaileble;
            value.CarFeatureCarId = request.CarFeatureCarId;
            value.CarFeatureFeatureId = request.CarFeatureFeatureId;
            await _carFeatureRepository.UpdateAsync(value);

        }
    }
}
