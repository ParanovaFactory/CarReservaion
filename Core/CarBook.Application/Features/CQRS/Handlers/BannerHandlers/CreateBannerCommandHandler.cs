﻿using CarBook.Application.Features.CQRS.Comments.BannerCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public CreateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBannerCommand command)
        {
            await _repository.CreateAsync(new Banner
            {
                BannerTitle = command.BannerTitle,
                BannerDescription = command.BannerDescription,
                BannerVideoUrl = command.BannerVideoUrl,
                BannerVideoDescription = command.BannerVideoDescription
            });
        }
    }
}
