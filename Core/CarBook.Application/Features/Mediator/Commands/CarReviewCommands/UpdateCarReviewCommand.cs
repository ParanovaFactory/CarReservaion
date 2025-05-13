using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CarReviewCommands
{
    public class UpdateCarReviewCommand : IRequest
    {
        public int CarReviewId { get; set; }
        public string CarReviewName { get; set; }
        public DateTime CarReviewDate { get; set; }
        public string CarReviewContent { get; set; }
        public int CarReviewRating { get; set; }
        public int CarReviewCarId { get; set; }
    }
}
