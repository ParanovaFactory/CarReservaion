using CarBook.Application.Features.CQRS.Comments.BannerCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var value = await _repository.GetByIdAsync(command.BannerId);
            value.BannerTitle = command.BannerTitle;
            value.BannerDescription = command.BannerDescription;
            value.BannerVideoDescription = command.BannerVideoDescription;
            value.BannerVideoUrl = command.BannerVideoUrl;
            await _repository.UpdateAsync(value);
        }
    }
}
