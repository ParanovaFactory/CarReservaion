using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureInterface
    {
        List<CarFeature> GetCarFeatureByCar(int id);
        void ChangeCarFeatureAvilebleToFalse(int id);
        void ChangeCarFeatureAvilebleToTrue(int id);
    }
}
