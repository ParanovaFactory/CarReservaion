using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogWithAutorByBlogQuery : IRequest<GetBlogWithAutorByBlogQueryResult>
    {
        public int id { get; set; }

        public GetBlogWithAutorByBlogQuery(int id)
        {
            this.id = id;
        }
    }
}
