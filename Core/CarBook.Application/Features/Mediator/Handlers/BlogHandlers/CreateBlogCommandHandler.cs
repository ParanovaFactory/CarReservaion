using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Blog
            {
                BlogTitle = request.BlogTitle,
                BlogAuthorId = request.BlogAuthorId,
                BlogCategoryId = request.BlogCategoryId,
                BlogContent = request.BlogContent,
                BlogCreatedDate = request.BlogCreatedDate,
                BlogCoverImageUrl = request.BlogCoverImageUrl
            });
        }
    }
}
