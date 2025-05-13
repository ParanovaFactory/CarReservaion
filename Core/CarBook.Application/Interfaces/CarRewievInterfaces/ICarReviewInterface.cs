using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarRewievInterfaces
{
    public interface ICarReviewInterface
    {
        List<CarReview> GetCarReviewByCarId(int id);
    }
}
