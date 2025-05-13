using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class ChangeCarFeatureAvilebleToTrueCommand : IRequest
    {
        public int id { get; set; }

        public ChangeCarFeatureAvilebleToTrueCommand(int id)
        {
            this.id = id;
        }
    }
}
