using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CarDescriptionResults
{
    public class GetCarDescriptionByCarIdQueryResult
    {
        public int CarDescriptionId { get; set; }
        public string CarDescriptionDetail { get; set; }
        public int CarDescriptionCarId { get; set; }
    }
}
