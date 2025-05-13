using CarBook.Application.Interfaces.StatisticInterfaces;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly CarBookContext _context;

        public StatisticRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetAuthorCount()
        {
            var values = _context.Authors.Count();
            return values;
        }

        public int GetCarCount()
        {
            var values = _context.Cars.Count();
            return values;
        }

        public int GetLocationCount()
        {
            var values = _context.Locations.Count();
            return values;
        }

        public int GetBlogCount()
        {
            var values = _context.Blogs.Count();
            return values;
        }

        public int GetBrandCount()
        {
            var values = _context.Brands.Count();
            return values;
        }

        public int GetAutoTransmissionCarCount()
        {
            var values = _context.Cars.Where(c => c.CarTransmission == "Automatic").Count();
            return values;
        }
        public decimal GetAvgRentPriceDaily()
        {
            decimal value = _context.CarPricings.Where(x => x.Pricing.PricingPeriod == "Daily").Average(x => x.CarPricingAmount);
            return value;
        }

        public decimal GetAvgRentPriceWeekly()
        {
            decimal value = _context.CarPricings.Where(x => x.Pricing.PricingPeriod == "Weekly").Average(x => x.CarPricingAmount);
            return value;
        }

        public decimal GetAvgRentPriceMonthly()
        {
            decimal value = _context.CarPricings.Where(x => x.Pricing.PricingPeriod == "Monthly").Average(x => x.CarPricingAmount);
            return value;
        }
        public string GetBrandMostCars()
        {
            string value = _context.Cars
                .GroupBy(c => c.Brand.BrandName)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();
            return value;
        }

        public string GetMostCommentedBlogTitle()
        {
            string value = _context.Blogs
                .Include(b => b.Comments)
                .OrderByDescending(b => b.Comments.Count())
                .Select(b => b.BlogTitle)
                .FirstOrDefault();
            return value;
        }

        public int GetGasolineCarCount()
        {
            var values = _context.Cars.Where(c => c.CarFuel == "Gasoline").Count();
            return values;
        }

        public int GetDieselCarCount()
        {
            var values = _context.Cars.Where(c => c.CarFuel == "Diesel").Count();
            return values;
        }

        public int GetHybridCarCount()
        {
            var values = _context.Cars.Where(c => c.CarFuel == "Hybrid").Count();
            return values;
        }

        public int GetLowKilometterCarCount()
        {
            var values = _context.Cars.Where(c => c.CarKilometer < 10000).Count();
            return values;
        }

        public string GetCheapestCarModel()
        {
            string value = _context.Cars
                .OrderBy(c => c.CarPricings.Min(cp => cp.CarPricingAmount))
                .Select(c => c.CarModel)
                .FirstOrDefault();
            return value;
        }

        public string GetMostExpensiveCarModel()
        {
            string value = _context.Cars
                .OrderByDescending(c => c.CarPricings.Max(cp => cp.CarPricingAmount))
                .Select(c => c.CarModel)
                .FirstOrDefault();
            return value;
        }
    }
}
