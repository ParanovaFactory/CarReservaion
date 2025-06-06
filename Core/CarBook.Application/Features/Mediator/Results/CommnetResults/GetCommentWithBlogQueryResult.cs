﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CommnetResults
{
    public class GetCommentWithBlogQueryResult
    {
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentDescription { get; set; }
        public int CommentBlogId { get; set; }
    }
}
