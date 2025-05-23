﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class RentACar
    {
        [Key]
        public int RentACarId { get; set; }
        public int PickUpLocationId { get; set; }
        [ForeignKey("PickUpLocationId")]
        public Location Location { get; set; }
        public int RentACarCarId { get; set; }
        [ForeignKey("RentACarCarId")]
        public Car Car { get; set; }
        public bool Available { get; set; }
    }
}
