using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarPricing
    {
        [Key]
        public int CarPricingId { get; set; }
        public int CarPricingCarId { get; set; }
        [ForeignKey("CarPricingCarId")]
        public Car Car { get; set; }
        public int CarPricingPricingId { get; set; }
        public Pricing Pricing { get; set; }
        public decimal CarPricingAmount { get; set; }
    }
}
