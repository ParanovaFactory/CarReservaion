using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarReview
    {
        [Key]
        public int CarReviewId { get; set; }
        public string CarReviewName { get; set; }
        public DateTime CarReviewDate { get; set; }
        public string CarReviewContent { get; set; }
        public int CarReviewRating { get; set; }
        public int CarReviewCarId { get; set; }
        [ForeignKey("CarReviewCarId")]
        public Car Car { get; set; }
    }
}
