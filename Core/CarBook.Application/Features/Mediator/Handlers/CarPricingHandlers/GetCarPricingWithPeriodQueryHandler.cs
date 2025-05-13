using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithPeriodQueryHandler : IRequestHandler<GetCarPricingWithPeriodQuery, List<GetCarPricingWithPeriodQueryResult>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPricingWithPeriodQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task<List<GetCarPricingWithPeriodQueryResult>> Handle(GetCarPricingWithPeriodQuery request, CancellationToken cancellationToken)
        {
            var carPricings = _carPricingRepository.GetCarPricingWithPeriod();

            return carPricings
                .GroupBy(x => new { x.Car.CarId, x.Car.CarModel, BrandName = x.Car.Brand.BrandName, CoverImage = x.Car.CarCoverImageUrl})
                .Select(g => new GetCarPricingWithPeriodQueryResult
                {
                    CarId = g.Key.CarId,
                    CarModel = g.Key.CarModel,
                    BrandName = g.Key.BrandName,
                    CoverImage = g.Key.CoverImage,
                    DailyPrice = g.FirstOrDefault(p => p.CarPricingPricingId == 1)?.CarPricingAmount ?? 0,
                    WeeklyPrice = g.FirstOrDefault(p => p.CarPricingPricingId == 2)?.CarPricingAmount ?? 0,
                    MonthlyPrice = g.FirstOrDefault(p => p.CarPricingPricingId == 3)?.CarPricingAmount ?? 0
                })
                .ToList();

        }
    }
}
