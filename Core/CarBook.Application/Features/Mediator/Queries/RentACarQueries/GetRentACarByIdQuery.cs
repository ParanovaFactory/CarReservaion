using CarBook.Application.Features.Mediator.Results.RentACarResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.RentACarQueries
{
    public class GetRentACarByIdQuery :IRequest<GetRentACarByIdQueryResult>
    {
        public int id { get; set; }

        public GetRentACarByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
