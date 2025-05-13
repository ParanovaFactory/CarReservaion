using CarBook.Application.Features.CQRS.Comments.AboutCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommands command)
        {
            var value = await _repository.GetByIdAsync(command.AboutId);
            value.AboutTitle = command.AboutTitle;
            value.AboutDescription = command.AboutDescription;
            value.AboutImageUrl = command.AboutImageUrl;
            await _repository.UpdateAsync(value);
        }
    }
}
