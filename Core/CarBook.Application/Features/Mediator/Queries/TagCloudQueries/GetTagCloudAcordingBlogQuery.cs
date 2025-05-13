using CarBook.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudAcordingBlogQuery : IRequest<List<GetTagCloudAcordingBlogQueryResult>>
    {
        public GetTagCloudAcordingBlogQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
