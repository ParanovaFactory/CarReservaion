﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.AuthorDtos
{
    public class CreateAuthorDto
    {
        public string AuthorName { get; set; }
        public string AuthorDescription { get; set; }
        public string AuthorImageUrl { get; set; }
    }
}
