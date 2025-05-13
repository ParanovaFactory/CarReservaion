using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CarFeatureQueries
{
    public class GetCarFeatureByCarQuery : IRequest<List<GetCarFeatureByCarQueryResult>>
    {
        public int id { get; set; }

        public GetCarFeatureByCarQuery(int id)
        {
            this.id = id;
        }
    }
}
