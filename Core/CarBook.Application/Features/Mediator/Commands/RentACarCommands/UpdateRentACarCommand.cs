using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.RentACarCommands
{
    public class UpdateRentACarCommand : IRequest
    {
        public int RentACarId { get; set; }
        public int PickUpLocationId { get; set; }
        public int RentACarCarId { get; set; }
        public bool Available { get; set; }
    }
}
