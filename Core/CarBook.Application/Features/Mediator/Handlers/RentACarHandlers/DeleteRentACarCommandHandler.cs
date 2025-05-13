using CarBook.Application.Features.Mediator.Commands.RentACarCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class DeleteRentACarCommandHandler : IRequestHandler<DeleteRentACarCommand>
    {
        private readonly IRepository<RentACar> _rentACarRepository;

        public DeleteRentACarCommandHandler(IRepository<RentACar> rentACarRepository)
        {
            _rentACarRepository = rentACarRepository;
        }

        public async Task Handle(DeleteRentACarCommand request, CancellationToken cancellationToken)
        {
            var value = await _rentACarRepository.GetByIdAsync(request.id);
            await _rentACarRepository.RemoveAsync(value);
        }
    }
}
