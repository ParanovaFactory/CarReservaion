﻿using CarBook.Application.Features.Mediator.Commands.BlogCommands;
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
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public DeleteBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);
            await _repository.RemoveAsync(value);
        }
    }
}
