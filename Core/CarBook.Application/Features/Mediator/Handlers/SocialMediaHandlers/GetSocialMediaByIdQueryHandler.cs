using CarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using MediatR;
using CarBook.Application.Features.Mediator.Results.SocialMediaResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);
            return new GetSocialMediaByIdQueryResult
            {
                SocialMediaIcon = value.SocialMediaIcon,
                SocialMediaName = value.SocialMediaName,
                SocialMediaUrl = value.SocialMediaUrl,
                SocialMediaId = value.SocialMediaId
            };
        }
    }
}
