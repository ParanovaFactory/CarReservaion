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
    public class GetAvgRentPriceMonthlyQueryHandler : IRequestHandler<GetAvgRentPriceMonthlyQuery, GetAvgRentPriceMonthlyQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetAvgRentPriceMonthlyQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetAvgRentPriceMonthlyQueryResult> Handle(GetAvgRentPriceMonthlyQuery request, CancellationToken cancellationToken)
        {
            var value = _statisticRepository.GetAvgRentPriceMonthly();
            return new GetAvgRentPriceMonthlyQueryResult
            {
                AvgPriceMonthly = value
            };
        }
    }
}
