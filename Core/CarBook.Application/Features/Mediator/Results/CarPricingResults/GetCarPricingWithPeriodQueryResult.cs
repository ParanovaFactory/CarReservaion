using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CarPricingResults
{
    public class GetCarPricingWithPeriodQueryResult
    {
        public int CarId { get; set; }
        public string CarModel { get; set; }
        public string BrandName { get; set; }
        public string CoverImage { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal WeeklyPrice { get; set; }
        public decimal MonthlyPrice { get; set; }
    }
}
