﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Comments.BannerCommands
{
    public class CreateBannerCommand
    {
        public string BannerTitle { get; set; }
        public string BannerDescription { get; set; }
        public string BannerVideoDescription { get; set; }
        public string BannerVideoUrl { get; set; }
    }
}
