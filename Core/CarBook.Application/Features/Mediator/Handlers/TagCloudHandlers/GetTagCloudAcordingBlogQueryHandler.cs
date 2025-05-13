using CarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using CarBook.Application.Features.Mediator.Results.TagCloudResults;
using CarBook.Application.Interfaces.TagCloudInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudAcordingBlogQueryHandler : IRequestHandler<GetTagCloudAcordingBlogQuery, List<GetTagCloudAcordingBlogQueryResult>>
    {
        private readonly ITagCloudRepository _tagCloudRepository;

        public GetTagCloudAcordingBlogQueryHandler(ITagCloudRepository tagCloudRepository)
        {
            _tagCloudRepository = tagCloudRepository;
        }

        public async Task<List<GetTagCloudAcordingBlogQueryResult>> Handle(GetTagCloudAcordingBlogQuery request, CancellationToken cancellationToken)
        {
            var values = _tagCloudRepository.GetTagCloudAcordingBlog(request.id);
            return values.Select(x => new GetTagCloudAcordingBlogQueryResult
            {
                TagCloudTitle = x.TagCloudTitle,
                TagCloudBlogId = x.TagCloudBlogId
            }).ToList();
        }
    }
}
