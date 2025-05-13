using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandler
{
    public class ChangeCarFeatureAvilebleToTrueCommandHandler : IRequestHandler<ChangeCarFeatureAvilebleToTrueCommand>
    {
        private readonly ICarFeatureInterface _carFeatureInterface;

        public ChangeCarFeatureAvilebleToTrueCommandHandler(ICarFeatureInterface carFeatureInterface)
        {
            _carFeatureInterface = carFeatureInterface;
        }

        public async Task Handle(ChangeCarFeatureAvilebleToTrueCommand request, CancellationToken cancellationToken)
        {
            _carFeatureInterface.ChangeCarFeatureAvilebleToTrue(request.id);
        }
    }
}
