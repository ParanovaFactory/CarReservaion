﻿using CarBook.Application.Features.Mediator.Results.ServiceResults;
using CarBook.Application.Inrfefaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
    {
        public GetServiceByIdQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
