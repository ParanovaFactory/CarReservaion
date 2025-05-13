using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.RentACarResults
{
    public class GetRentACarByIdQueryResult
    {
        public int RentACarId { get; set; }
        public int PickUpLocationId { get; set; }
        public int RentACarCarId { get; set; }
        public bool Available { get; set; }
    }
}
