using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CarReviewCommands
{
    public class DeleteCarReviewCommand : IRequest
    {
        public int id { get; set; }

        public DeleteCarReviewCommand(int id)
        {
            this.id = id;
        }
    }
}
