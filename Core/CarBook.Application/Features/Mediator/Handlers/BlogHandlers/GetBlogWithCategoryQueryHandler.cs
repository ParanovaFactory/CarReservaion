using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogWithCategoryQueryHandler : IRequestHandler<GetBlogWithCategoryQuery, List<GetBlogWithCategoryQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetBlogWithCategoryQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetBlogWithCategoryQueryResult>> Handle(GetBlogWithCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = _blogRepository.GetBlogWithCategoryName();
            return values.Select(x => new GetBlogWithCategoryQueryResult
            {
                BlogAuthorId = x.BlogAuthorId,
                BlogCategoryId = x.BlogCategoryId,
                BlogCategoryName = x.Category.CategoryName,
                BlogContent = x.BlogContent,
                BlogCoverImageUrl = x.BlogCoverImageUrl,
                BlogCreatedDate = x.BlogCreatedDate,
                BlogId = x.BlogId,
                BlogTitle = x.BlogTitle
            }).ToList();
        }
    }
}
