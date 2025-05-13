using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Queries.BreandQueries;
using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public GetBrandByIdQueryHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery request)
        {
            var value = await _brandRepository.GetByIdAsync(request.id);
            return new GetBrandByIdQueryResult
            {
                BrandName = value.BrandName
            };
        }
    }
}
