using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CarPricingCommands
{
    public class DeleteCarPricingCommand : IRequest
    {
        public int id { get; set; }

        public DeleteCarPricingCommand(int id)
        {
            this.id = id;
        }
    }
}
