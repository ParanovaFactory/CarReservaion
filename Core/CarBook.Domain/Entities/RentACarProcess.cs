using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class RentACarProcess
    {
        [Key]
        public int RentACarProcessId { get; set; }
        public int RentACarProcessCarId { get; set; }
        [ForeignKey("RentACarProcessCarId")]
        public Car Car { get; set; }
        public int RentACarProcessPickUpLocationId { get; set; }
        public int RentACarProcessDropOffLocationId { get; set; }
        public DateOnly RentACarProcessPickUpDate { get; set; }
        public DateOnly RentACarProcessDropOffDate { get; set; }
        public TimeOnly RentACarProcessPickUpTime { get; set; }
        public TimeOnly RentACarProcessDropOffTime { get; set; }
        public int RentACarProcessCustomerId { get; set; }
        [ForeignKey("RentACarProcessCustomerId")]
        public Customer Customer { get; set; }
        public string RentACarProcessPickUpDescription { get; set; }
        public string RentACarProcessDropOffDescription { get; set; }
        public decimal RentACarProcessTotalPrice { get; set; }
    }
}
