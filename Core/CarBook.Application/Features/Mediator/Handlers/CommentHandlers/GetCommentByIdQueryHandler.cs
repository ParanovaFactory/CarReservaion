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
    public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQuery, GetCommentByIdQueryResult>
    {
        private readonly IRepository<Comment> _commentRepository;

        public GetCommentByIdQueryHandler(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<GetCommentByIdQueryResult> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _commentRepository.GetByIdAsync(request.id);
            return new GetCommentByIdQueryResult
            {
                CommentId = value.CommentId,
                CommentName = value.CommentName,
                CommentDate = value.CommentDate,
                CommentDescription = value.CommentDescription,
                CommentBlogId = value.CommentBlogId
            };
        }
    }
}
