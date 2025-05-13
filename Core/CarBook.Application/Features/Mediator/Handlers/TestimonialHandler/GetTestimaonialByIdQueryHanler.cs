using CarBook.Application.Features.Mediator.Queries.TestimonialQueries;
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
    public class GetTestimaonialByIdQueryHanler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimaonialByIdQueryHanler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);
            return new GetTestimonialByIdQueryResult
            {
                TestimonialId = value.TestimonialId,
                TestimonialName = value.TestimonialName,
                TestimonialTitle = value.TestimonialTitle,
                TestimonialComment = value.TestimonialComment,
                TestimonialImageUrl = value.TestimonialImageUrl
            };
        }
    }
}
