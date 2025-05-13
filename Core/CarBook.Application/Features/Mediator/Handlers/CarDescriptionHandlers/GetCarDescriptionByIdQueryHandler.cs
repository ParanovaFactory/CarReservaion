using CarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
using CarBook.Application.Features.Mediator.Results.CarDescriptionResults;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarDescriptionHandlers
{
    public class GetCarDescriptionByIdQueryHandler : IRequestHandler<GetCarDescriptionByIdQuery, GetCarDescriptionByIdQueryResult>
    {
        private readonly IRepository<CarDescription> _repository;

        public GetCarDescriptionByIdQueryHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarDescriptionByIdQueryResult> Handle(GetCarDescriptionByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);
            return new GetCarDescriptionByIdQueryResult
            {
                CarDescriptionCarId = value.CarDescriptionCarId,
                CarDescriptionId = value.CarDescriptionId,
                CarDescriptionDetail = value.CarDescriptionDetail
            };
        }
    }
}
