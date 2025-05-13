using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarFeature
    {
        [Key]
        public int CarFeatureId { get; set; }
        public int CarFeatureCarId { get; set; }
        [ForeignKey("CarFeatureCarId")]
        public Car Car { get; set; }
        public int CarFeatureFeatureId { get; set; }
        public Feature Feature { get; set; }
        public bool CarFeatureAvaileble { get; set; }
    }
}
