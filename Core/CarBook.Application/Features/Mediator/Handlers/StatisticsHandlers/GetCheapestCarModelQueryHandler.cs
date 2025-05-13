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
    public class GetCheapestCarModelQueryHandler : IRequestHandler<GetCheapestCarModelQuery, GetCheapestCarModelQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetCheapestCarModelQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetCheapestCarModelQueryResult> Handle(GetCheapestCarModelQuery request, CancellationToken cancellationToken)
        {
            var value = _statisticRepository.GetCheapestCarModel();
            return new GetCheapestCarModelQueryResult
            {
                CarCheapestModel = value
            };
        }
    }
}
