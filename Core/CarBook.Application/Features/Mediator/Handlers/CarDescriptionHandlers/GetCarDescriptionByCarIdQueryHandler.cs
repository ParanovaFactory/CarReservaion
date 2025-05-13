using CarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
using CarBook.Application.Features.Mediator.Results.CarDescriptionResults;
using CarBook.Application.Interfaces.CarDescriptionInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarDescriptionHandlers
{
    public class GetCarDescriptionByCarIdQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionByCarIdQueryResult>
    {
        private readonly ICarDescriptionInterface _carDescriptionInterface;

        public GetCarDescriptionByCarIdQueryHandler(ICarDescriptionInterface carDescriptionInterface)
        {
            _carDescriptionInterface = carDescriptionInterface;
        }

        public async Task<GetCarDescriptionByCarIdQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
        {
            var value = _carDescriptionInterface.GetByCarId(request.id);

            return new GetCarDescriptionByCarIdQueryResult
            {
                CarDescriptionId = value.CarDescriptionId,
                CarDescriptionCarId = value.CarDescriptionCarId,
                CarDescriptionDetail = value.CarDescriptionDetail
            };
        }
    }
}
/*
var value = _carDescriptionInterface.GetByCarId(request.id);

return new GetCarDescriptionByCarIdQueryResult
{
    CarDescriptionId = value.CarDescriptionId,
    CarDescriptionCarId = value.CarDescriptionCarId,
    CarDescriptionDetail = value.CarDescriptionDetail
};
*/