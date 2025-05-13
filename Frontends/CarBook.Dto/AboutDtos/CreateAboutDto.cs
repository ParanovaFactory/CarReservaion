using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.AboutDtos
{
    public class CreateAboutDto
    {
        public string aboutTitle { get; set; }
        public string aboutDescription { get; set; }
        public string aboutImageUrl { get; set; }
    }
}
