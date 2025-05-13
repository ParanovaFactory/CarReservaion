using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class DeleteFooterAddressCommand : IRequest
    {
        public DeleteFooterAddressCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
