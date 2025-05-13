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
    public class DeleteCarPricingCommandHandler : IRequestHandler<DeleteCarPricingCommand>
    {
        private readonly IRepository<CarPricing> _carPricingRepository;

        public DeleteCarPricingCommandHandler(IRepository<CarPricing> carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task Handle(DeleteCarPricingCommand request, CancellationToken cancellationToken)
        {
            var value = await _carPricingRepository.GetByIdAsync(request.id);
            await _carPricingRepository.RemoveAsync(value);
        }
    }
}
