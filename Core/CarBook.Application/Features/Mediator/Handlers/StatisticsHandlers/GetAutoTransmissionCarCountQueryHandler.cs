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
    public class GetAutoTransmissionCarCountQueryHandler : IRequestHandler<GetAutoTransmissionCarCountQuery, GetAutoTransmissionCarCountQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetAutoTransmissionCarCountQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetAutoTransmissionCarCountQueryResult> Handle(GetAutoTransmissionCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _statisticRepository.GetAutoTransmissionCarCount();
            return new GetAutoTransmissionCarCountQueryResult
            {
                AutoTransmissionCarCount = value
            };
        }
    }
}
