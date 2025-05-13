using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int AuthorCount { get; set; }
        public string CarExpensiveModel { get; set; }
        public string CarCheapestModel { get; set; }
        public string BlogTitle { get; set; }
        public int LowKilometerCarCount { get; set; }
        public int LocationCount { get; set; }
        public int HybridCarCount { get; set; }
        public int GasolineCarCount { get; set; }
        public int DieselCarCount { get; set; }
        public int CarCount { get; set; }
        public string CommonBrand { get; set; }
        public int BrandCount { get; set; }
        public int BlogCount { get; set; }
        public int AutoTransmissionCarCount { get; set; }
        public decimal AvgPriceDaily { get; set; }
        public decimal AvgPriceWeekly { get; set; }
        public decimal AvgPriceMonthly { get; set; }
    }
}
