using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CarPricingCommands
{
    public class CreateCarPricingCommand : IRequest
    {
        public int CarPricingCarId { get; set; }
        public int CarPricingPricingId { get; set; }
        public decimal CarPricingAmount { get; set; }
    }
}
