﻿using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.id);
            return new GetAboutByIdQueryResult
            {
                AboutId = value.AboutId,
                AboutTitle = value.AboutTitle,
                AboutDescription = value.AboutDescription,
                AboutImageUrl = value.AboutImageUrl
            };
        }
    }
}
