using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
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
    public class GetCarPricingByIdQueryHandler : IRequestHandler<GetCarPricingByIdQuery, GetCarPricingByIdQueryResult>
    {
        private readonly IRepository<CarPricing> _carPricingRepository;

        public GetCarPricingByIdQueryHandler(IRepository<CarPricing> carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task<GetCarPricingByIdQueryResult> Handle(GetCarPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _carPricingRepository.GetByIdAsync(request.id);
            return new GetCarPricingByIdQueryResult
            {
                CarPricingId = value.CarPricingId,
                CarPricingCarId = value.CarPricingCarId,
                CarPricingPricingId = value.CarPricingPricingId,
                CarPricingAmount = value.CarPricingAmount
            };
        }
    }
}
