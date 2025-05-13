using CarBook.Application.Features.Mediator.Queries.CarReviewQuries;
using CarBook.Application.Features.Mediator.Results.CarDescriptionResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarReviewHandlers
{
    public class GetCarReviewByIdQueryHandler : IRequestHandler<GetCarReviewByIdQuery, GetCarReviewByIdQueryResult>
    {
        private readonly IRepository<CarReview> _carReviewRepository;

        public GetCarReviewByIdQueryHandler(IRepository<CarReview> carReviewRepository)
        {
            _carReviewRepository = carReviewRepository;
        }

        public async Task<GetCarReviewByIdQueryResult> Handle(GetCarReviewByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _carReviewRepository.GetByIdAsync(request.id);
            return new GetCarReviewByIdQueryResult
            {
                CarReviewCarId = value.CarReviewCarId,
                CarReviewContent = value.CarReviewContent,
                CarReviewRating = value.CarReviewRating,
                CarReviewDate = value.CarReviewDate,
                CarReviewName = value.CarReviewName
            };
        }
    }
}
