using CarBook.Application.Features.Mediator.Commands.CommentCommands;
using CarBook.Application.Features.Mediator.Queries.CommnetQueries;
using CarBook.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Comments : ControllerBase
    {
        private readonly IMediator _mediator;

        public Comments(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CreateComment()
        {
            var query = new GetCommentQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> CommentById(int id)
        {
            var query = new GetCommentByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Comment was added");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var command = new DeleteCommentCommand(id);
            await _mediator.Send(command);
            return Ok("Comment was deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Comment was updated");
        }

        [HttpGet("CommentWithBlog{id}")]
        public async Task<IActionResult> CommentWithBlog(int id)
        {
            var query = new GetCommentWithBlogQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
