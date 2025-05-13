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
    public class GetCarPricingQueryHandler : IRequestHandler<GetCarPricingQuery, List<GetCarPricingQueryResult>>
    {
        private readonly IRepository<CarPricing> _carPricingRepository;

        public GetCarPricingQueryHandler(IRepository<CarPricing> carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task<List<GetCarPricingQueryResult>> Handle(GetCarPricingQuery request, CancellationToken cancellationToken)
        {
            var value = await _carPricingRepository.GetAllAsync();
            return value.Select(x => new GetCarPricingQueryResult
            {
                CarPricingId = x.CarPricingId,
                CarPricingCarId = x.CarPricingCarId,
                CarPricingPricingId = x.CarPricingPricingId,
                CarPricingAmount = x.CarPricingAmount
            }).ToList();
        }
    }
}
