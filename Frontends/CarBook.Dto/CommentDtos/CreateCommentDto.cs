﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.CommentDtos
{
    public class CreateCommentDto
    {
        public string CommentName { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentDescription { get; set; }
        public int CommentBlogId { get; set; }
    }
}
