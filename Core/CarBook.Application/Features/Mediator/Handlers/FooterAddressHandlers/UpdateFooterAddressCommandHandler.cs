using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FooterAddressId);
            value.FooterAddressDesciription = request.FooterAddressDesciription;
            value.FooterAddressAddress = request.FooterAddressAddress;
            value.FooterAddressPhone = request.FooterAddressPhone;
            value.FooterAddressEmail = request.FooterAddressEmail;
            await _repository.UpdateAsync(value);
        }
    }
}
