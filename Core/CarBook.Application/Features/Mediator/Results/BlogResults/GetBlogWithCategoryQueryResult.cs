using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogWithCategoryQueryResult
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public int BlogAuthorId { get; set; }
        public int BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; }
        public string BlogContent { get; set; }
        public DateTime BlogCreatedDate { get; set; }
        public string BlogCoverImageUrl { get; set; }
    }
}
