using CarBook.Application.Features.Mediator.Results.CommnetResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CommnetQueries
{
    public class GetCommentByIdQuery : IRequest<GetCommentByIdQueryResult>
    {
        public int id { get; set; }

        public GetCommentByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
