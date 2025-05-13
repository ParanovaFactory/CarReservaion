using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        List<Blog> GetBlogWithAuthorName();
        List<Blog> GetBlogWithCategoryName();
        List<Blog> GetLast3BlogsWithAuthorName();
        Blog GetBlogWithAuthorByBlog(int id);
    }
}
