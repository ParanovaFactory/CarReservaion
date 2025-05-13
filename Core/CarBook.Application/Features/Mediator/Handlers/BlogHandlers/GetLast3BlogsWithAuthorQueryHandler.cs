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
    public class GetLast3BlogsWithAuthorQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorQuery, List<GetLast3BlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetLast3BlogsWithAuthorQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogsWithAuthorQueryResult>> Handle(GetLast3BlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLast3BlogsWithAuthorName();
            return values.Select(x => new GetLast3BlogsWithAuthorQueryResult
            {
                BlogAuthorId = x.BlogAuthorId,
                BlogAuthorName = x.Author.AuthorName,
                BlogCategoryId = x.BlogCategoryId,
                BlogContent = x.BlogContent,
                BlogCoverImageUrl = x.BlogCoverImageUrl,
                BlogCreatedDate = x.BlogCreatedDate,
                BlogId = x.BlogId,
                BlogTitle = x.BlogTitle
            }).ToList();
        }
    }
}
