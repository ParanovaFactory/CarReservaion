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
    internal class DeleteCarFeatureCommandHandler : IRequestHandler<DeleteCarFeatureCommand>
    {
        private readonly IRepository<CarFeature> _carFeatureRepository;

        public DeleteCarFeatureCommandHandler(IRepository<CarFeature> carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task Handle(DeleteCarFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _carFeatureRepository.GetByIdAsync(request.id);
            await _carFeatureRepository.RemoveAsync(value);
        }
    }
}
