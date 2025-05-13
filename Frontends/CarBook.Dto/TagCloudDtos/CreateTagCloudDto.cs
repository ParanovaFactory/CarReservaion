using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.TagCloudDtos
{
    public class CreateTagCloudDto
    {
        public int TagCloudId { get; set; }
        public string TagCloudTitle { get; set; }
        public int TagCloudBlogId { get; set; }
    }
}
