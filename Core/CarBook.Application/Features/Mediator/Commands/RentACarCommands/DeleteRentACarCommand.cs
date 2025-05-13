using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.RentACarCommands
{
    public class DeleteRentACarCommand : IRequest
    {
        public int id { get; set; }

        public DeleteRentACarCommand(int id)
        {
            this.id = id;
        }
    }
}
