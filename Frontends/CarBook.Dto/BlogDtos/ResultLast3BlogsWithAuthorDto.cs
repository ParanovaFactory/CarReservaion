using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.BlogDtos
{
    public class ResultLast3BlogsWithAuthorDto
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public int BlogAuthorId { get; set; }
        public string BlogAuthorName { get; set; }
        public int BlogCategoryId { get; set; }
        public string BlogContent { get; set; }
        public DateTime BlogCreatedDate { get; set; }
        public string BlogCoverImageUrl { get; set; }
    }
}
