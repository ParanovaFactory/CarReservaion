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
    public class GetHybridCarCountQueryHandler : IRequestHandler<GetHybridCarCountQuery, GetHybridCarCountQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetHybridCarCountQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetHybridCarCountQueryResult> Handle(GetHybridCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _statisticRepository.GetHybridCarCount();
            return new GetHybridCarCountQueryResult
            {
                HybridCarCount = value
            };
        }
    }
}
