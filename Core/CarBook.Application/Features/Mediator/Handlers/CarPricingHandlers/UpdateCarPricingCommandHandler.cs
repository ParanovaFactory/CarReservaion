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
    public class UpdateCarPricingCommandHandler : IRequestHandler<UpdateCarPricingCommand>
    {
        private readonly IRepository<CarPricing> _carPricingRepository;

        public UpdateCarPricingCommandHandler(IRepository<CarPricing> carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task Handle(UpdateCarPricingCommand request, CancellationToken cancellationToken)
        {
            var carPricing = await _carPricingRepository.GetByIdAsync(request.CarPricingId);
            carPricing.CarPricingCarId = request.CarPricingCarId;
            carPricing.CarPricingAmount = request.CarPricingAmount;
            carPricing.CarPricingPricingId = request.CarPricingPricingId;
            await _carPricingRepository.UpdateAsync(carPricing);
        }
    }
}
