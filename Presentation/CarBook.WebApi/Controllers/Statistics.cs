using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Statistics : ControllerBase
    {
        private readonly IMediator _mediator;

        public Statistics(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarCount")]
        public async Task<IActionResult> GetCarCount()
        {
            var result = await _mediator.Send(new GetCarCountQuery());
            return Ok(result);
        }

        [HttpGet("GetLocationCount")]
        public async Task<IActionResult> GetLocationCount()
        {
            var result = await _mediator.Send(new GetLocationCountQuery());
            return Ok(result);
        }

        [HttpGet("GetAuthorCount")]
        public async Task<IActionResult> GetAuthorCount()
        {
            var result = await _mediator.Send(new GetAuthorCountQuery());
            return Ok(result);
        }

        [HttpGet("GetBlogCount")]
        public async Task<IActionResult> GetBlogCount()
        {
            var result = await _mediator.Send(new GetBlogCountQuery());
            return Ok(result);
        }

        [HttpGet("GetBrandCount")]
        public async Task<IActionResult> GetBrandCount()
        {
            var result = await _mediator.Send(new GetBrandCountQuery());
            return Ok(result);
        }

        [HttpGet("GetGasolineCarCount")]
        public async Task<IActionResult> GetGasolineCarCount()
        {
            var result = await _mediator.Send(new GetGasolineCarCountQuery());
            return Ok(result);
        }

        [HttpGet("GetDieselCarCount")]
        public async Task<IActionResult> GetDieselCarCount()
        {
            var result = await _mediator.Send(new GetDieselCarCountQuery());
            return Ok(result);
        }

        [HttpGet("GetHybridCarCount")]
        public async Task<IActionResult> GetHybridCarCount()
        {
            var result = await _mediator.Send(new GetHybridCarCountQuery());
            return Ok(result);
        }

        [HttpGet("GetLowKilometterCarCount")]
        public async Task<IActionResult> GetLowKilometterCarCount()
        {
            var result = await _mediator.Send(new GetLowKilometterCarCountQuery());
            return Ok(result);
        }

        [HttpGet("GetAutoTransmissionCarCount")]
        public async Task<IActionResult> GetAutoTransmissionCarCount()
        {
            var result = await _mediator.Send(new GetAutoTransmissionCarCountQuery());
            return Ok(result);
        }
        //
        [HttpGet("GetAvgRentPriceDaily")]
        public async Task<IActionResult> GetAvgRentPriceDaily()
        {
            var result = await _mediator.Send(new GetAvgRentPriceDailyQuery());
            return Ok(result);
        }

        [HttpGet("GetAvgRentPriceWeekly")]
        public async Task<IActionResult> GetAvgRentPriceWeekly()
        {
            var result = await _mediator.Send(new GetAvgRentPriceWeeklyQuery());
            return Ok(result);
        }

        //
        [HttpGet("GetAvgRentPriceMonthly")]
        public async Task<IActionResult> GetAvgRentPriceMonthly()
        {
            var result = await _mediator.Send(new GetAvgRentPriceMonthlyQuery());
            return Ok(result);
        }

        [HttpGet("GetBrandMostCars")]
        public async Task<IActionResult> GetBrandMostCars()
        {
            var result = await _mediator.Send(new GetBrandMostCarsQuery());
            return Ok(result);
        }

        [HttpGet("GetMostCommentedBlogTitle")]
        public async Task<IActionResult> GetMostCommentedBlogTitle()
        {
            var result = await _mediator.Send(new GetMostCommentedBlogTitleQuery());
            return Ok(result);
        }

        [HttpGet("GetCheapestCarModel")]
        public async Task<IActionResult> GetCheapestCarModel()
        {
            var result = await _mediator.Send(new GetCheapestCarModelQuery());
            return Ok(result);
        }

        [HttpGet("GetMostExpensiveCarModel")]
        public async Task<IActionResult> GetMostExpensiveCarModel()
        {
            var result = await _mediator.Send(new GetMostExpensiveCarModelQuery());
            return Ok(result);
        }
    }
}
