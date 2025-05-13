using CarBook.Application.Interfaces.CarRewievInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CarReviewRepositories
{
    public class CarReviewRepository : ICarReviewInterface
    {
        private readonly CarBookContext _context;

        public CarReviewRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<CarReview> GetCarReviewByCarId(int id)
        {
           var values = _context.CarReviews.Where(x => x.CarReviewCarId == id).ToList();
           return values;
        }
    }
}
