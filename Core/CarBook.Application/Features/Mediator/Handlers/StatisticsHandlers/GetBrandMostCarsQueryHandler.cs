using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetBrandMostCarsQueryHandler : IRequestHandler<GetBrandMostCarsQuery, GetBrandMostCarsQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetBrandMostCarsQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetBrandMostCarsQueryResult> Handle(GetBrandMostCarsQuery request, CancellationToken cancellationToken)
        {
            var value = _statisticRepository.GetBrandMostCars();
            return new GetBrandMostCarsQueryResult
            {
                CommonBrand = value
            };
        }
    }
}
