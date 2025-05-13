using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarByIdWithBrandQuery
    {
        public int id { get; set; }

        public GetCarByIdWithBrandQuery(int id)
        {
            this.id = id;
        }
    }
}
