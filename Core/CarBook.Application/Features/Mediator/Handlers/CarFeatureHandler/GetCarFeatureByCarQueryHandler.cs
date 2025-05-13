using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandler
{
    public class GetCarFeatureByCarQueryHandler : IRequestHandler<GetCarFeatureByCarQuery, List<GetCarFeatureByCarQueryResult>>
    {
        private readonly ICarFeatureInterface _carFeatureRepository;

        public GetCarFeatureByCarQueryHandler(ICarFeatureInterface carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task<List<GetCarFeatureByCarQueryResult>> Handle(GetCarFeatureByCarQuery request, CancellationToken cancellationToken)
        {
            var values = _carFeatureRepository.GetCarFeatureByCar(request.id);
            return values.Select(x => new GetCarFeatureByCarQueryResult
            {
                CarFeatureId = x.CarFeatureId,
                CarFeatureCarId = x.CarFeatureCarId,
                CarFeatureFeatureId = x.CarFeatureFeatureId,
                CarFeatureAvaileble = x.CarFeatureAvaileble,
                FeatureName = x.Feature.FeatureName
            }).ToList();
        }
    }
}
