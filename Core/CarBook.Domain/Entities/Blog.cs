using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public int BlogAuthorId { get; set; }
        [ForeignKey("BlogAuthorId")]
        public Author Author { get; set; }
        public int BlogCategoryId { get; set; }
        [ForeignKey("BlogCategoryId")]
        public Category Category { get; set; }
        public string BlogContent { get; set; }
        public DateTime BlogCreatedDate { get; set; }
        public string BlogCoverImageUrl { get; set; }
        public List<TagCloud> TagClouds { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
