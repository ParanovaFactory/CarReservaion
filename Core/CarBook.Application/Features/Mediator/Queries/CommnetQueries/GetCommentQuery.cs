﻿using CarBook.Application.Features.Mediator.Results.CommnetResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CommnetQueries
{
    public class GetCommentQuery : IRequest<List<GetCommentQueryResult>>
    {
    }
}
