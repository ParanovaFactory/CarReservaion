using CarBook.Application.Features.Mediator.Queries.CarReviewQuries;
using CarBook.Application.Features.Mediator.Results.CarDescriptionResults;
using CarBook.Application.Interfaces.CarRewievInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarReviewHandlers
{
    public class GetCarReviewByCarIdQueryHandler : IRequestHandler<GetCarReviewByCarIdQuery, List<GetCarReviewByCarIdQueryResult>>
    {
        private readonly ICarReviewInterface _carReviewInterface;

        public GetCarReviewByCarIdQueryHandler(ICarReviewInterface carReviewInterface)
        {
            _carReviewInterface = carReviewInterface;
        }

        public async Task<List<GetCarReviewByCarIdQueryResult>> Handle(GetCarReviewByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _carReviewInterface.GetCarReviewByCarId(request.id);
            return values.Select(x => new GetCarReviewByCarIdQueryResult
            {
                CarReviewId = x.CarReviewId,
                CarReviewName = x.CarReviewName,
                CarReviewDate = x.CarReviewDate,
                CarReviewContent = x.CarReviewContent,
                CarReviewRating = x.CarReviewRating,
                CarReviewCarId = x.CarReviewCarId
            }).ToList();
        }
    }
}
