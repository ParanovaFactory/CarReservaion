﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.LocationCommands
{
    public class DeleteLocationCommand : IRequest
    {
        public DeleteLocationCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
