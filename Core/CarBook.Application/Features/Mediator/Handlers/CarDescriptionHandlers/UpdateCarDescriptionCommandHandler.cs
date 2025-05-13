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
    public class UpdateCarDescriptionCommandHandler : IRequestHandler<UpdateCarDescriptionCommand>
    {
        private readonly IRepository<CarDescription> _repository;

        public UpdateCarDescriptionCommandHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarDescriptionCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.CarDescriptionId);
            value.CarDescriptionDetail = request.CarDescriptionDetail;
            value.CarDescriptionCarId = request.CarDescriptionCarId;
            await _repository.UpdateAsync(value);
        }
    }
}
