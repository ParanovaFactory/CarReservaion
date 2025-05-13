using CarBook.Application.Features.Mediator.Queries.CommnetQueries;
using CarBook.Application.Features.Mediator.Results.CommnetResults;
using CarBook.Application.Inrfefaces;
using CarBook.Application.Interfaces.CommnetInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentWithBlogQueryHandler : IRequestHandler<GetCommentWithBlogQuery, List<GetCommentWithBlogQueryResult>>
    {
        private readonly ICommentInterface _commentRepository;

        public GetCommentWithBlogQueryHandler(ICommentInterface commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<List<GetCommentWithBlogQueryResult>> Handle(GetCommentWithBlogQuery request, CancellationToken cancellationToken)
        {
            var values =  _commentRepository.GetCommentsWithBlog(request.id);
            return values.Select(x => new GetCommentWithBlogQueryResult
            {
                CommentId = x.CommentId,
                CommentBlogId = x.CommentBlogId,
                CommentName = x.CommentName,
                CommentDescription = x.CommentDescription,
                CommentDate = x.CommentDate
            }).ToList();
        }
    }
}
