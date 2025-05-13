using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Comments.AboutCommands
{
    public class RemoveAboutCommand
    {
        public RemoveAboutCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
