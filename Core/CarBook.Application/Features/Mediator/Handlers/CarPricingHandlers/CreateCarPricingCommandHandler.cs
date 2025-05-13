using CarBook.Application.Features.Mediator.Commands.CarPricingCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class CreateCarPricingCommandHandler : IRequestHandler<CreateCarPricingCommand>
    {
        private readonly IRepository<CarPricing> _carPricingRepository;

        public CreateCarPricingCommandHandler(IRepository<CarPricing> carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task Handle(CreateCarPricingCommand request, CancellationToken cancellationToken)
        {
            await _carPricingRepository.CreateAsync(new CarPricing
            {
                CarPricingAmount = request.CarPricingAmount,
                CarPricingPricingId = request.CarPricingPricingId,
                CarPricingCarId = request.CarPricingCarId,
            });
        }
    }
}
