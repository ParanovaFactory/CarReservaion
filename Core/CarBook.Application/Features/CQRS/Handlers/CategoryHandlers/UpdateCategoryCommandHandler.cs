using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCategoryCommand category)
        {
            var value = await _repository.GetByIdAsync(category.CategoryId);
            value.CategoryName = category.CategoryName;
            await _repository.UpdateAsync(value);
        }
    }
}
