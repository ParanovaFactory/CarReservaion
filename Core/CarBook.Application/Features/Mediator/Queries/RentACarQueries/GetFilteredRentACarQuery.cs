﻿using CarBook.Application.Features.Mediator.Results.RentACarResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.RentACarQueries
{
    public class GetFilteredRentACarQuery : IRequest<List<GetFilteredRentACarQueryResult>>
    {
        public int PickUpLocationId { get; set; }
        public bool Available { get; set; }
    }
}
