using CarBook.Application.Features.Mediator.Results.BookingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.BookingQueries
{
    public class GetBookingQuery : IRequest<List<GetBookingQueryResult>>
    {
    }
}
