using CarBook.Application.Features.Mediator.Results.CarDescriptionResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CarReviewQuries
{
    public class GetCarReviewByIdQuery : IRequest<GetCarReviewByIdQueryResult>
    {
        public int id { get; set; }

        public GetCarReviewByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
