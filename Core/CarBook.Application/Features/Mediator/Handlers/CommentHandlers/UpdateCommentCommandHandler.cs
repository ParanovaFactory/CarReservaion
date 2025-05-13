using CarBook.Application.Features.Mediator.Commands.CommentCommands;
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
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand>
    {
        private readonly IRepository<Comment> _commentRepository;

        public UpdateCommentCommandHandler(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            var value = await _commentRepository.GetByIdAsync(request.CommentId);
            value.CommentName = request.CommentName;
            value.CommentDescription = request.CommentDescription;
            value.CommentDate = request.CommentDate;
            value.CommentBlogId = request.CommentBlogId;
            await _commentRepository.UpdateAsync(value);
        }
    }
}
