using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.FooterAddressResults
{
    public class GetFooterAddressByIdQueryResult
    {
        public int FooterAddressId { get; set; }
        public string FooterAddressDesciription { get; set; }
        public string FooterAddressAddress { get; set; }
        public string FooterAddressPhone { get; set; }
        public string FooterAddressEmail { get; set; }
    }
}
