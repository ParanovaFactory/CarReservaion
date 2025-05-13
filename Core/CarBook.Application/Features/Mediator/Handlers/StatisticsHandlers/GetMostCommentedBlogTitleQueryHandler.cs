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
    public class GetMostCommentedBlogTitleQueryHandler : IRequestHandler<GetMostCommentedBlogTitleQuery, GetMostCommentedBlogTitleQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetMostCommentedBlogTitleQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetMostCommentedBlogTitleQueryResult> Handle(GetMostCommentedBlogTitleQuery request, CancellationToken cancellationToken)
        {
            var value = _statisticRepository.GetMostCommentedBlogTitle();
            return new GetMostCommentedBlogTitleQueryResult
            {
                BlogTitle = value
            };
        }
    }
}
