using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Blogs : ControllerBase
    {
        private readonly IMediator _mediator;

        public Blogs(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var query = new GetBlogQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BlogById(int id)
        {
            var query = new GetBlogByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog was added");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var command = new DeleteBlogCommand(id);
            await _mediator.Send(command);
            return Ok("Blog was deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog was updated");
        }

        [HttpGet("BlogWithAuthor")]
        public async Task<IActionResult> BlogWithAuthor()
        {
            var query = new GetAllBlogWithAutorsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("BlogWithCategory")]
        public async Task<IActionResult> BlogWithCategory()
        {
            var query = new GetBlogWithCategoryQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("Last3BlogsWithAuthor")]
        public async Task<IActionResult> Last3BlogsWithAuthor()
        {
            var query = new GetLast3BlogsWithAuthorQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("GetAuthorByBlogs")]
        public async Task<IActionResult> GetAuthorByBlogs(int id)
        {
            var query = new GetBlogWithAutorByBlogQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
