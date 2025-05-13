using CarBook.Application.Features.CQRS.Queries.BannerQueries;
using CarBook.Application.Features.CQRS.Results.BannerResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.id);
            return new GetBannerByIdQueryResult
            {
                BannerId = value.BannerId,
                BannerTitle = value.BannerTitle,
                BannerDescription = value.BannerDescription,
                BannerVideoDescription = value.BannerVideoDescription,
                BannerVideoUrl = value.BannerVideoUrl,
                BannerImageUrl = value.BannerImageUrl
            };
        }
    }
}
