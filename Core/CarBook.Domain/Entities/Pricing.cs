using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Pricing
    {
        [Key]
        public int PricingId { get; set; }
        public string PricingPeriod { get; set; }
        public List<CarPricing> CarPricings { get; set; }

    }
}
