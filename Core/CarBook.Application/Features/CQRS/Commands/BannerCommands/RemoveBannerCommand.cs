﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Comments.BannerCommands
{
    public class RemoveBannerCommand
    {
        public RemoveBannerCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
