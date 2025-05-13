using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers
{
    public class GetAllBlogWithAutorsQueryHandler : IRequestHandler<GetAllBlogWithAutorsQuery, List<GetAllBlogWithAutorsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetAllBlogWithAutorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllBlogWithAutorsQueryResult>> Handle(GetAllBlogWithAutorsQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogWithAuthorName();
            return value.Select(x => new GetAllBlogWithAutorsQueryResult
            {
                BlogId = x.BlogId,
                BlogTitle = x.BlogTitle,
                BlogAuthorId = x.BlogAuthorId,
                BlogAuthorName = x.Author.AuthorName,
                AuthorDescription = x.Author.AuthorDescription,
                AuthorImageUrl = x.Author.AuthorImageUrl,
                BlogCategoryId = x.BlogCategoryId,
                BlogContent = x.BlogContent,
                BlogCreatedDate = x.BlogCreatedDate,
                BlogCoverImageUrl = x.BlogCoverImageUrl
            }).ToList();
        }
    }
}
