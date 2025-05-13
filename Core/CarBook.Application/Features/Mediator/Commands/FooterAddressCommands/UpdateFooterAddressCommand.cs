using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class UpdateFooterAddressCommand : IRequest
    {
        public int FooterAddressId { get; set; }
        public string FooterAddressDesciription { get; set; }
        public string FooterAddressAddress { get; set; }
        public string FooterAddressPhone { get; set; }
        public string FooterAddressEmail { get; set; }
    }
}
