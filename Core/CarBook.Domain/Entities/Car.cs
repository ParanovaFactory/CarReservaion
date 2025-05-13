using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public int CarBrandId { get; set; }
        [ForeignKey("CarBrandId")]
        public Brand Brand { get; set; }
        public string CarModel { get; set; }
        public string CarCoverImageUrl { get; set; }
        public int CarKilometer { get; set; }
        public string CarTransmission { get; set; }
        public byte CarSeats { get; set; }
        public byte CarLuggage { get; set; }
        public string CarFuel { get; set; }
        public string CarBigImageUrl { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public List<CarPricing> CarPricings { get; set; }
        public List<RentACar> RentACars { get; set; }
        public List<RentACarProcess> RentACarProcesses { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<CarReview> CarReviews { get; set; }
    }
}
