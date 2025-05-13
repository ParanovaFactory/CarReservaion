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
    public class GetCarDescriptionQueryHandler : IRequestHandler<GetCarDescriptionQuery, List<GetCarDescriptionQueryResult>>
    {
        private readonly IRepository<CarDescription> _repository;

        public GetCarDescriptionQueryHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarDescriptionQueryResult>> Handle(GetCarDescriptionQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarDescriptionQueryResult
            {
                CarDescriptionId = x.CarDescriptionId,
                CarDescriptionCarId = x.CarDescriptionCarId,
                CarDescriptionDetail = x.CarDescriptionDetail
            }).ToList();
        }
    }
}
