using BeldYazilim.Application.Features.Mediator.Commands.ArticleCategories;
using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
using BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoriesQueries;
using BeldYazilim.Persistence.Context;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BeldYazilim.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleCategoryController : ControllerBase
    {

        private readonly IMediator _mediator;


        public ArticleCategoryController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpPost("CreateArticleCategoryLink")]
        public async Task<IActionResult> CreateArticleCategoryLink([FromBody] CreateArticleCategoryLinkCommand command)
        {

            await _mediator.Send(command);
            return Ok("CreateArticleCategoryLink başarıyla eklendi");

        }


        [HttpPost("CreateSubcategory")]
        public async Task<IActionResult> CreateSubcategory([FromBody] CreateSubcategoryCommand command)
        {

            await _mediator.Send(command);
            return Ok("CreateSubcategory başarıyla eklendi");

        }
        [HttpPost("CreateMainCategory")]
        public async Task<IActionResult> CreateMainCategory([FromBody] CreateMainCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("CreateMainCategory başarıyla eklendi");
        }

        [HttpGet("GetMainCategory")]
        public async Task<IActionResult> GetMainCategories()
        {
            var values = await _mediator.Send(new GetArticleMainCategoryQuery());
            return Ok(values);
        }

        [HttpGet("GetMainCategoryById/{id}")]
        public async Task<IActionResult> GetMainCategoryById(int id)
        {
            var value = await _mediator.Send(new GetArticleMainCategoryByIdQuery(id));
            return Ok(value);

        }

        [HttpGet("GetSubCategory")]
        public async Task<IActionResult> GetSubCategories()
        {
            var values = await _mediator.Send(new GetArticleSubCategoryQuery());
            return Ok(values);
        }

        [HttpGet("GetSubCategoryById/{id}")]
        public async Task<IActionResult> GetSubCategoryById(int id)
        {
            var value = await _mediator.Send(new GetArticleSubCategoryByIdQuery(id));
            return Ok(value);
        }

        [HttpGet("GetLinkCategory")]
        public async Task<IActionResult> GetLinkCategories()
        {
            var values = await _mediator.Send(new GetArticleCategoryLinkQuery());
            return Ok(values);
        }

        [HttpGet("GetLinkCategoryById/{id}")]
        public async Task<IActionResult> GetLinkCategoryById(int id)
        {
            var value = await _mediator.Send(new GetArticleCategoryLinkByIdQuery(id));
            return Ok(value);
        }



        [HttpPut("update-main-category")]
        public async Task<IActionResult> UpdateMainCategory( [FromBody] UpdateMainCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("main-category başarıyla güncellendi");

        }

        [HttpPut("update-subcategory")]
        public async Task<IActionResult> UpdateSubcategory([FromBody] UpdateSubcategoryCommand command)
        {

            await _mediator.Send(command);
            return Ok("subcategory başarıyla güncellendi");
        }
        [HttpPut("update-article-category-link")]
        public async Task<IActionResult> UpdateArticleCategoryLink( [FromBody] UpdateArticleCategoryLinkCommand command)
        {
            await _mediator.Send(command);
            return Ok("article-category-link başarıyla güncellendi");
        }




    }
}
