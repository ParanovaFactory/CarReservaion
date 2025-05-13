using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CommentCommands
{
    public class DeleteCommentCommand : IRequest
    {
        public int id { get; set; }

        public DeleteCommentCommand(int id)
        {
            this.id = id;
        }
    }
}
