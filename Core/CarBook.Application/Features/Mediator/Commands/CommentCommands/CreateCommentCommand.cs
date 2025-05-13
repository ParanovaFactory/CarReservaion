using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CommentCommands
{
    public class CreateCommentCommand : IRequest
    {
        public string CommentName { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentDescription { get; set; }
        public int CommentBlogId { get; set; }
    }
}
