using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.RentACarDtos
{
    public class CreateRentACarDto
    {
        public int PickUpLocationId { get; set; }
        public int RentACarCarId { get; set; }
        public bool Available { get; set; }
    }
}
