using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBook.Application.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Catergories : ControllerBase
    {
        private readonly CreateCategoryCommandHandler _createCatergoryCommandHandler;
        private readonly GetCategoryByIdQueryHandler _getCatergoryByIdQueryHandler;
        private readonly GetCategoryQueryHandler _getCatergoryQueryHandler;
        private readonly UpdateCategoryCommandHandler _updateCatergoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCatergoryCommandHandler;

        public Catergories(CreateCategoryCommandHandler createCatergoryCommandHandler, GetCategoryByIdQueryHandler getCatergoryByIdQueryHandler, GetCategoryQueryHandler getCatergoryQueryHandler, UpdateCategoryCommandHandler updateCatergoryCommandHandler, RemoveCategoryCommandHandler removeCatergoryCommandHandler)
        {
            _createCatergoryCommandHandler = createCatergoryCommandHandler;
            _getCatergoryByIdQueryHandler = getCatergoryByIdQueryHandler;
            _getCatergoryQueryHandler = getCatergoryQueryHandler;
            _updateCatergoryCommandHandler = updateCatergoryCommandHandler;
            _removeCatergoryCommandHandler = removeCatergoryCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CatergoryList()
        {
            var result = await _getCatergoryQueryHandler.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> CatergoryById(int id)
        {
            var result = await _getCatergoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCatergory(CreateCategoryCommand command)
        {
            await _createCatergoryCommandHandler.Handle(command);
            return Ok("Catergory was added");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCatergory(int id)
        {
            await _removeCatergoryCommandHandler.Handle(new RemoveCategoryCommand(id));
            return Ok("Catergory was removed");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCatergory(UpdateCategoryCommand command)
        {
            await _updateCatergoryCommandHandler.Handle(command);
            return Ok("Catergory was updated");
        }
    }
}
