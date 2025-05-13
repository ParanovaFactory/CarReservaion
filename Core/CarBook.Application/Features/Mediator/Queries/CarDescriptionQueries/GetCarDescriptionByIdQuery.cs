using CarBook.Application.Features.Mediator.Results.CarDescriptionResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CarDescriptionQueries
{
    public class GetCarDescriptionByIdQuery : IRequest<GetCarDescriptionByIdQueryResult>
    {
        public int id { get; set; }

        public GetCarDescriptionByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
