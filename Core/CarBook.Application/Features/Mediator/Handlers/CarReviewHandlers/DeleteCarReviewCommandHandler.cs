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
    public class DeleteCarReviewCommandHandler : IRequestHandler<DeleteCarReviewCommand>
    {
        private readonly IRepository<CarReview> _carReviewRepository;

        public DeleteCarReviewCommandHandler(IRepository<CarReview> carReviewRepository)
        {
            _carReviewRepository = carReviewRepository;
        }

        public async Task Handle(DeleteCarReviewCommand request, CancellationToken cancellationToken)
        {
            var value = await _carReviewRepository.GetByIdAsync(request.id);
            await _carReviewRepository.RemoveAsync(value);
        }
    }
}
