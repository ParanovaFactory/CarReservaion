﻿using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.BreandQueries
{
    public class GetBrandByIdQuery
    {
        public GetBrandByIdQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
