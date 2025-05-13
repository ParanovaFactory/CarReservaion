using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.ServiceCommands
{
    public class DeleteServiceCommand : IRequest
    {
        public DeleteServiceCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
