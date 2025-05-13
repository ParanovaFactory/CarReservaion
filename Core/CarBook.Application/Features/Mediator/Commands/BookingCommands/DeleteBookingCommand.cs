using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.BookingCommands
{
    public class DeleteBookingCommand : IRequest
    {
        public int id { get; set; }

        public DeleteBookingCommand(int id)
        {
            this.id = id;
        }
    }
}
