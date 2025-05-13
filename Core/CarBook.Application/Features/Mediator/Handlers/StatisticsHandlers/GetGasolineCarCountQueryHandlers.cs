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
    public class GetGasolineCarCountQueryHandlers : IRequestHandler<GetGasolineCarCountQuery, GetGasolineCarCountQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetGasolineCarCountQueryHandlers(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetGasolineCarCountQueryResult> Handle(GetGasolineCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _statisticRepository.GetGasolineCarCount();
            return new GetGasolineCarCountQueryResult
            {
                GasolineCarCount = value
            };
        }
    }
}
