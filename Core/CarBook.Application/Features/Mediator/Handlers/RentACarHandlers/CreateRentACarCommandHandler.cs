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
    public class CreateRentACarCommandHandler : IRequestHandler<CreateRentACarCommand>
    {
        private readonly IRepository<RentACar> _rentACarRepository;

        public CreateRentACarCommandHandler(IRepository<RentACar> rentACarRepository)
        {
            _rentACarRepository = rentACarRepository;
        }

        public async Task Handle(CreateRentACarCommand request, CancellationToken cancellationToken)
        {
            await _rentACarRepository.CreateAsync(new RentACar
            {
                PickUpLocationId = request.PickUpLocationId,
                RentACarCarId = request.RentACarCarId,
                Available = request.Available
            });
        }
    }
}
