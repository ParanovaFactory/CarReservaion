using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.RentACarResults
{
    public class GetFilteredRentACarQueryResult
    {
        public int RentACarId { get; set; }
        public int RentACarCarId { get; set; }
        public string CarModel { get; set; }
        public string BrandName { get; set; }
        public decimal PricingAmount { get; set; }
        public string CarCoverImageUrl { get; set; }
    }
}
