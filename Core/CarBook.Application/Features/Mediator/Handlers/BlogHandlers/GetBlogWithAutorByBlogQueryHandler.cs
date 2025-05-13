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
    public class GetBlogWithAutorByBlogQueryHandler : IRequestHandler<GetBlogWithAutorByBlogQuery, GetBlogWithAutorByBlogQueryResult>
    {
        private readonly IBlogRepository _repository;

        public GetBlogWithAutorByBlogQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetBlogWithAutorByBlogQueryResult> Handle(GetBlogWithAutorByBlogQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogWithAuthorByBlog(request.id);
            return new GetBlogWithAutorByBlogQueryResult
            {
                BlogId = value.BlogId,
                BlogTitle = value.BlogTitle,
                BlogAuthorId = value.BlogAuthorId,
                BlogCategoryId = value.BlogCategoryId,
                BlogContent = value.BlogContent,
                BlogCreatedDate = value.BlogCreatedDate,
                BlogCoverImageUrl = value.BlogCoverImageUrl,
                BlogAuthorName = value.Author.AuthorName,
                AuthorDescription = value.Author.AuthorDescription,
                AuthorImageUrl = value.Author.AuthorImageUrl
            };
        }
    }
}
