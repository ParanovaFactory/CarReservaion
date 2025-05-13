using CarBook.Application.Interfaces.CarFeatureInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CarFeatureRepostories
{
    public class CarFeatureRepository : ICarFeatureInterface
    {
        private readonly CarBookContext _context;

        public CarFeatureRepository(CarBookContext context)
        {
            _context = context;
        }

        public void ChangeCarFeatureAvilebleToFalse(int id)
        {
            var values = _context.CarFeatures.Where(x => x.CarFeatureId == id).FirstOrDefault();
            values.CarFeatureAvaileble = false;
            _context.SaveChanges();
        }

        public void ChangeCarFeatureAvilebleToTrue(int id)
        {
            var values = _context.CarFeatures.Where(x => x.CarFeatureId == id).FirstOrDefault();
            values.CarFeatureAvaileble = true;
            _context.SaveChanges();
        }

        public List<CarFeature> GetCarFeatureByCar(int id)
        {
            var values = _context.CarFeatures.Where(x => x.CarFeatureCarId == id).Include(x => x.Feature).ToList();
            return values;
        }
    }
}
