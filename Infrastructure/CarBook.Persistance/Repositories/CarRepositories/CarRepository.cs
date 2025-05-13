using CarBook.Application.Inrfefaces.CarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrand()
        {
            var values = _context.Cars
                .Include(x => x.Brand)
                .ToList();
            return values;
        }

        public List<Car> GetLast5CarsWithBrand()
        {
            var values = _context.Cars
                .Include(x => x.Brand)
                .OrderByDescending(x => x.CarId)
                .Take(5)
                .ToList();
            return values;
        }

        Car ICarRepository.GetCarByIdWithBrand(int id)
        {
            var values = _context.Cars
               .Where(x => x.CarId == id)
               .Include(x => x.Brand)
               .FirstOrDefault();
            return values;
        }
    }
}
