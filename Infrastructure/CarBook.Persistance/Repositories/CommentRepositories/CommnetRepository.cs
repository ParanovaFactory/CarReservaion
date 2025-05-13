using CarBook.Application.Interfaces.CommnetInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CommentRepositories
{
    public class CommnetRepository : ICommentInterface
    {
        private readonly CarBookContext _context;

        public CommnetRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Comment> GetCommentsWithBlog(int id)
        {
            var values = _context.Comments.Where(x => x.CommentBlogId == id).ToList();
            return values;
        }
    }
}
