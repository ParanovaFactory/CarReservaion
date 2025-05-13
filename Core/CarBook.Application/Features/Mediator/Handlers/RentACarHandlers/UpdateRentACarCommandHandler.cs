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
    public class UpdateRentACarCommandHandler : IRequestHandler<UpdateRentACarCommand>
    {
        private readonly IRepository<RentACar> _rentACarRepository;

        public UpdateRentACarCommandHandler(IRepository<RentACar> rentACarRepository)
        {
            _rentACarRepository = rentACarRepository;
        }

        public async Task Handle(UpdateRentACarCommand request, CancellationToken cancellationToken)
        {
            var value = await _rentACarRepository.GetByIdAsync(request.RentACarId);
            value.PickUpLocationId = request.PickUpLocationId;
            value.RentACarCarId = request.RentACarCarId;
            value.Available = request.Available;
            await _rentACarRepository.UpdateAsync(value);
        }
    }
}
