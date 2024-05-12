using BeldYazilim.Application.Features.Mediator.Commands.ArticleCategoryCommands;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoryQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArticleMainCategoryCategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArticleMainCategoryCategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ArticleMainCategoryList()
        {
            var values = await _mediator.Send(new GetArticleMainCategoryQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleMainCategory(int id)
        {
            var value = await _mediator.Send(new GetArticleMainCategoryByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateArticleMainCategory(CreateMainCategoryArticleCommand command)
        {

            await _mediator.Send(command);
            return Ok("ArticleMainCategory başarıyla eklendi");

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveArticleMainCategory(int id)
        {
            await _mediator.Send(new RemoveMainCategoryArticleCommand(id));
            return Ok("ArticleMainCategory başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArticleMainCategory(UpdateMainCategoryArticleCommand command)
        {
            await _mediator.Send(command);
            return Ok("ArticleMainCategory başarıyla güncellendi");
        }
    }
}
