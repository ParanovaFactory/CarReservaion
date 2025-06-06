﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.CarResults
{
    public class GetLast5CarsWithBrandQueryResult
    {
        public int CarId { get; set; }
        public int CarBrandId { get; set; }
        public string CarBrandName { get; set; }
        public string CarModel { get; set; }
        public string CarCoverImageUrl { get; set; }
        public int CarKilometer { get; set; }
        public string CarTransmission { get; set; }
        public byte CarSeats { get; set; }
        public byte CarLuggage { get; set; }
        public string CarFuel { get; set; }
        public string CarBigImageUrl { get; set; }
    }
}
