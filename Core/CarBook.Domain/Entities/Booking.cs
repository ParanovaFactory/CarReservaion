using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [ForeignKey("BookingCarId")]
        public int BookingCarId { get; set; }
        [ForeignKey("PickUpLocationId")]
        public int? PickUpLocationId { get; set; }
        [ForeignKey("CarBrandId")]
        public int? DropOffLocationId { get; set; }
        public int Age { get; set; }
        public int DriverLicense { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; }
        public Location PickUpLocation { get; set; }
        public Location DropOffLocation { get; set; }
        public Car BookingCar { get; set; }
    }
}
