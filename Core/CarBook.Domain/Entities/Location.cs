using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public List<RentACar> RentACars { get; set; }
        public List<Booking> PickUpBooking { get; set; }
        public List<Booking> DropoffBooking { get; set; }
    }
}
