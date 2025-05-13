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
    public class GetCarFeatureByIdQueryHandler : IRequestHandler<GetCarFeatureByIdQuery, GetCarFeatureByIdQueryResult>
    {
        private readonly IRepository<CarFeature> _carFeatureRepository;

        public GetCarFeatureByIdQueryHandler(IRepository<CarFeature> carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task<GetCarFeatureByIdQueryResult> Handle(GetCarFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _carFeatureRepository.GetByIdAsync(request.id);

            return new GetCarFeatureByIdQueryResult
            {
                CarFeatureId = value.CarFeatureId,
                CarFeatureCarId = value.CarFeatureCarId,
                CarFeatureFeatureId = value.CarFeatureFeatureId,
                CarFeatureAvaileble = value.CarFeatureAvaileble
            };
        }
    }
}
