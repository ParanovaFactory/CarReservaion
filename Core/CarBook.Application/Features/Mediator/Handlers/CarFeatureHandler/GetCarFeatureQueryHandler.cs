using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandler
{
    public class GetCarFeatureQueryHandler : IRequestHandler<GetCarFeatureQuery, List<GetCarFeatureQueryResult>>
    {
        private readonly IRepository<CarFeature> _carFeatureRepository;

        public GetCarFeatureQueryHandler(IRepository<CarFeature> carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task<List<GetCarFeatureQueryResult>> Handle(GetCarFeatureQuery request, CancellationToken cancellationToken)
        {
            var values = await _carFeatureRepository.GetAllAsync();
            return values.Select(x => new GetCarFeatureQueryResult
            {
                CarFeatureCarId = x.CarFeatureFeatureId,
                CarFeatureFeatureId = x.CarFeatureCarId,
                CarFeatureAvaileble = x.CarFeatureAvaileble,
                CarFeatureId = x.CarFeatureId
            }).ToList();
        }
    }
}
