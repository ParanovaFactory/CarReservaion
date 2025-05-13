using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CarFeatureResults
{
    public class GetCarFeatureByIdQueryResult
    {
        public int CarFeatureId { get; set; }
        public int CarFeatureCarId { get; set; }
        public int CarFeatureFeatureId { get; set; }
        public bool CarFeatureAvaileble { get; set; }
    }
}
