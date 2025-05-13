using CarBook.Application.Features.Mediator.Commands.CarReviewCommands;
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
    public class CreateCarReviewCommandHandler : IRequestHandler<CreateCarReviewCommand>
    {
        private readonly IRepository<CarReview> _carReviewRepository;

        public CreateCarReviewCommandHandler(IRepository<CarReview> carReviewRepository)
        {
            _carReviewRepository = carReviewRepository;
        }

        public async Task Handle(CreateCarReviewCommand request, CancellationToken cancellationToken)
        {
            var value = new CarReview
            {
                CarReviewCarId = request.CarReviewCarId,
                CarReviewContent = request.CarReviewContent,
                CarReviewRating = request.CarReviewRating,
                CarReviewDate = DateTime.Now,
                CarReviewName = request.CarReviewName
            };
            await _carReviewRepository.CreateAsync(value);
        }
    }
}
