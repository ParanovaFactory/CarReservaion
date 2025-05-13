using CarBook.Application.Features.Mediator.Commands.TagCloudCommands;
using CarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagClouds : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagClouds(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagCloudList()
        {
            var query = new GetTagCloudQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> TagCloudById(int id)
        {
            var query = new GetTagCloudByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("TagCloud was added");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTagCloud(int id)
        {
            var command = new DeleteTagCloudCommand(id);
            await _mediator.Send(command);
            return Ok("TagCloud was deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("TagCloud was updated");
        }

        [HttpGet("GetTagCloudAcordingBlog")]
        public async Task<IActionResult> GetTagCloudAcordingBlog(int id)
        {
            var query = new GetTagCloudAcordingBlogQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
