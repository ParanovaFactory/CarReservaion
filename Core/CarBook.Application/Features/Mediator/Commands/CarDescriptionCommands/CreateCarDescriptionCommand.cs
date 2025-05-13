using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CarDescriptionCommands
{
    public class CreateCarDescriptionCommand : IRequest
    {
        public string CarDescriptionDetail { get; set; }
        public int CarDescriptionCarId { get; set; }
    }
}
