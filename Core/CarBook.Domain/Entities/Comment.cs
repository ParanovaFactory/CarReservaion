using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentDescription{ get; set; }
        public int CommentBlogId { get; set; }
        [ForeignKey("CommentBlogId")]
        public Blog Blog { get; set; }
    }
}
