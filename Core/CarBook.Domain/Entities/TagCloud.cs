using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class TagCloud
    {
        [Key]
        public int TagCloudId { get; set; }
        public string TagCloudTitle { get; set; }
        public int TagCloudBlogId { get; set; }
        [ForeignKey("TagCloudBlogId")]
        public Blog Blog { get; set; }
    }
}
