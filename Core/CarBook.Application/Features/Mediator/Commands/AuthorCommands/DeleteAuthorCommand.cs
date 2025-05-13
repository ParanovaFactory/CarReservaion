﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.AuthorCommands
{
    public class DeleteAuthorCommand : IRequest
    {
        public DeleteAuthorCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
