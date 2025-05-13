using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class ChangeCarFeatureAvilebleToFalseCommand : IRequest
    {
        public int id { get; set; }

        public ChangeCarFeatureAvilebleToFalseCommand(int id)
        {
            this.id = id;
        }
    }
}
