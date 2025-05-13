using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.CarDescriptionDtos
{
    public class CarDescriptionDto
    {
        public int CarDescriptionId { get; set; }
        public string CarDescriptionDetail { get; set; }
        public int CarDescriptionCarId { get; set; }
    }
}
