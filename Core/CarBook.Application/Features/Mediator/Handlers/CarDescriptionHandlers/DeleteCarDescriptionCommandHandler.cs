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
    public class DeleteCarDescriptionCommandHandler : IRequestHandler<DeleteCarDescriptionCommand>
    {
        private readonly IRepository<CarDescription> _repository;

        public DeleteCarDescriptionCommandHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteCarDescriptionCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);
            await _repository.RemoveAsync(value);
        }
    }
}
