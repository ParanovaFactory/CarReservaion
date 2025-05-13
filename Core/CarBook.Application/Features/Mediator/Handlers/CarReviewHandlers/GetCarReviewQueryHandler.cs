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
    public class GetCarReviewQueryHandler : IRequestHandler<GetCarReviewQuery, List<GetCarReviewQueryResult>>
    {
        private readonly IRepository<CarReview> _carReviewRepository;

        public GetCarReviewQueryHandler(IRepository<CarReview> carReviewRepository)
        {
            _carReviewRepository = carReviewRepository;
        }

        public async Task<List<GetCarReviewQueryResult>> Handle(GetCarReviewQuery request, CancellationToken cancellationToken)
        {
            var valuew = await _carReviewRepository.GetAllAsync();
            return valuew.Select(x => new GetCarReviewQueryResult
            {
                CarReviewId = x.CarReviewId,
                CarReviewCarId = x.CarReviewCarId,
                CarReviewContent = x.CarReviewContent,
                CarReviewRating = x.CarReviewRating,
                CarReviewDate = x.CarReviewDate,
                CarReviewName = x.CarReviewName
            }).ToList();
        }
    }
}
