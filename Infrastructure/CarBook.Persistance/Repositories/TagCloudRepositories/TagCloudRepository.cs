﻿using CarBook.Application.Interfaces.TagCloudInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly CarBookContext _context;

        public TagCloudRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<TagCloud> GetTagCloudAcordingBlog(int id)
        {
            var values = _context.TagClouds
                .Where(x => x.TagCloudBlogId == id)
                .ToList();
            return values;
        }
    }
}
