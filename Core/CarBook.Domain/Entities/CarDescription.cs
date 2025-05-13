using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarDescription
    {
        [Key]
        public int CarDescriptionId { get; set; }
        public string CarDescriptionDetail { get; set; }
        public int CarDescriptionCarId { get; set; }
        [ForeignKey("CarDescriptionCarId")]
        public Car Car { get; set; }
    }
}
