using CarBook.Application.Features.Mediator.Commands.CarDescriptionCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarDescriptionHandlers
{
    public class CreateCarDescriptionCommandHandler : IRequestHandler<CreateCarDescriptionCommand>
    {
        private readonly IRepository<CarDescription> _repository;

        public CreateCarDescriptionCommandHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarDescriptionCommand request, CancellationToken cancellationToken)
        {
            var carDescription = new CarDescription
            {
                CarDescriptionCarId = request.CarDescriptionCarId,
                CarDescriptionDetail = request.CarDescriptionDetail,
            };
            await _repository.CreateAsync(carDescription);
        }
    }
}
