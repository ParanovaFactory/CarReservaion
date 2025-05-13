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
    public class GetDieselCarCountQueryHandler : IRequestHandler<GetDieselCarCountQuery, GetDieselCarCountQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetDieselCarCountQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetDieselCarCountQueryResult> Handle(GetDieselCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _statisticRepository.GetDieselCarCount();
            return new GetDieselCarCountQueryResult
            {
                DieselCarCount = value
            };
        }
    }
}
