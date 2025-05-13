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
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand>
    {
        private readonly IRepository<Comment> _commentRepository;

        public CreateCommentCommandHandler(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var value = new Comment
            {
                CommentName = request.CommentName,
                CommentDescription = request.CommentDescription,
                CommentDate = request.CommentDate,
                CommentBlogId = request.CommentBlogId
            };
            await _commentRepository.CreateAsync(value);
        }
    }
}
