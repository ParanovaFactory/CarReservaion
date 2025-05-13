using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CarPricingResults
{
    public class GetCarPricingQueryResult
    {
        public int CarPricingId { get; set; }
        public int CarPricingCarId { get; set; }
        public int CarPricingPricingId { get; set; }
        public decimal CarPricingAmount { get; set; }
    }
}
