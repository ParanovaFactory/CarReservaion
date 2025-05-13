using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.RentACarResults
{
    public class GetRentACarQueryResult
    {
        public int RentACarId { get; set; }
        public int PickUpLocationId { get; set; }
        public int RentACarCarId { get; set; }
        public bool Available { get; set; }
    }
}
