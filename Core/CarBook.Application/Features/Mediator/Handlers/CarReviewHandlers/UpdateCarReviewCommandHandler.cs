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
    public class UpdateCarReviewCommandHandler : IRequestHandler<UpdateCarReviewCommand>
    {
        private readonly IRepository<CarReview> _carReviewRepository;

        public UpdateCarReviewCommandHandler(IRepository<CarReview> carReviewRepository)
        {
            _carReviewRepository = carReviewRepository;
        }

        public async Task Handle(UpdateCarReviewCommand request, CancellationToken cancellationToken)
        {
            var value = await _carReviewRepository.GetByIdAsync(request.CarReviewId);
            value.CarReviewDate = DateTime.Now;
            value.CarReviewName = request.CarReviewName;
            value.CarReviewContent = request.CarReviewContent;
            value.CarReviewRating = request.CarReviewRating;
            value.CarReviewCarId = request.CarReviewCarId;
            await _carReviewRepository.UpdateAsync(value);
        }
    }
}
