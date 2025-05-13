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
    public class GetLowKilometterCarCountQueryHandler : IRequestHandler<GetLowKilometterCarCountQuery, GetLowKilometterCarCountQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetLowKilometterCarCountQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetLowKilometterCarCountQueryResult> Handle(GetLowKilometterCarCountQuery request, CancellationToken cancellationToken)
        {
            var values = _statisticRepository.GetLowKilometterCarCount();
            return new GetLowKilometterCarCountQueryResult
            {
                LowKilometerCarCount = values
            };
        }
    }
}
