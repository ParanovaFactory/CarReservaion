using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CarDescriptionCommands
{
    public class DeleteCarDescriptionCommand : IRequest
    {
        public int id { get; set; }

        public DeleteCarDescriptionCommand(int id)
        {
            this.id = id;
        }
    }
}
