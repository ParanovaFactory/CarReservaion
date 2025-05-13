using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class FooterAddress
    {
        [Key]
        public int FooterAddressId { get; set; }
        public string FooterAddressDesciription { get; set; }
        public string FooterAddressAddress { get; set; }
        public string FooterAddressPhone { get; set; }
        public string FooterAddressEmail{ get; set; }
    }
}
