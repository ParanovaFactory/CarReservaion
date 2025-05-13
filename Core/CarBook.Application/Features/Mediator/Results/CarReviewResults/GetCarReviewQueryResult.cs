using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CarDescriptionResults
{
    public class GetCarReviewQueryResult
    {
        public int CarReviewId { get; set; }
        public string CarReviewName { get; set; }
        public DateTime CarReviewDate { get; set; }
        public string CarReviewContent { get; set; }
        public int CarReviewRating { get; set; }
        public int CarReviewCarId { get; set; }
    }
}
