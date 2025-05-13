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
    public class ChangeCarFeatureAvilebleToFalseCommandHandler : IRequestHandler<ChangeCarFeatureAvilebleToFalseCommand>
    {
        private readonly ICarFeatureInterface _carFeatureInterface;

        public ChangeCarFeatureAvilebleToFalseCommandHandler(ICarFeatureInterface carFeatureInterface)
        {
            _carFeatureInterface = carFeatureInterface;
        }

        public async Task Handle(ChangeCarFeatureAvilebleToFalseCommand request, CancellationToken cancellationToken)
        {
            _carFeatureInterface.ChangeCarFeatureAvilebleToFalse(request.id);
        }
    }
}
