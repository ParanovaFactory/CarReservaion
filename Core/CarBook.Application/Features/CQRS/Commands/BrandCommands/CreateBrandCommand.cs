using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Comments.BrandCommands
{
    public class CreateBrandCommand
    {
        public string BrandName { get; set; }
    }
}
