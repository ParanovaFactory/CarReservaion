using CarBook.Application.Features.Mediator.Queries.CommnetQueries;
using CarBook.Application.Features.Mediator.Results.CommnetResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, List<GetCommentQueryResult>>
    {
        private readonly IRepository<Comment> _commentRepository;

        public GetCommentQueryHandler(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<List<GetCommentQueryResult>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var values = await _commentRepository.GetAllAsync();
            return values.Select(x => new GetCommentQueryResult
            {
                CommentId = x.CommentId,
                CommentName = x.CommentName,
                CommentDate = x.CommentDate,
                CommentDescription = x.CommentDescription,
                CommentBlogId = x.CommentBlogId
            }).ToList();
        }
    }
}
