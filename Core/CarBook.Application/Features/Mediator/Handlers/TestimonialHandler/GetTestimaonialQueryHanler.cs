﻿using CarBook.Application.Features.Mediator.Queries.TestimonialQueries;
using CarBook.Application.Features.Mediator.Results.TestimonialResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.TestimonialHandler
{
    public class GetTestimaonialQueryHanler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimaonialQueryHanler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                TestimonialId = x.TestimonialId,
                TestimonialName = x.TestimonialName,
                TestimonialTitle = x.TestimonialTitle,
                TestimonialComment = x.TestimonialComment,
                TestimonialImageUrl = x.TestimonialImageUrl
            }).ToList();
        }
    }
}
