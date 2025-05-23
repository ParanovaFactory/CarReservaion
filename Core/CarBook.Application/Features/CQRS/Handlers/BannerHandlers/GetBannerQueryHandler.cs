﻿using CarBook.Application.Features.CQRS.Results.BannerResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBannerQueryResult
            {
                BannerDescription = x.BannerDescription,
                BannerId = x.BannerId,
                BannerTitle = x.BannerTitle,
                BannerVideoDescription = x.BannerVideoDescription,
                BannerVideoUrl = x.BannerVideoUrl,
                BannerImageUrl = x.BannerImageUrl
            }).ToList();
        }
    }
}
