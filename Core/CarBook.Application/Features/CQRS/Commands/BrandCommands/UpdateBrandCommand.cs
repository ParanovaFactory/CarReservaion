using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Comments.BrandCommands
{
    public class UpdateBrandCommand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
