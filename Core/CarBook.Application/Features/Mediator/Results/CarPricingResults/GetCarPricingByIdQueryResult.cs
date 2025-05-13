using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CarPricingResults
{
    public class GetCarPricingByIdQueryResult
    {
        public int CarPricingId { get; set; }
        public int CarPricingCarId { get; set; }
        public int CarPricingPricingId { get; set; }
        public decimal CarPricingAmount { get; set; }
    }
}
