using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
using BeldYazilim.Persistence.Context;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly BeldYazilimContext _context;


        public ArticleController(IMediator mediator, BeldYazilimContext context)
        {
            _mediator = mediator;

            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> ArticleList()
        {
            var values = await _mediator.Send(new GetArticleQuery());
            return Ok(values);
        }

        [HttpGet("ArticleListWithAuthors")]
        public async Task<IActionResult> ArticleListWithAuthors()
        {
            var values = await _mediator.Send(new GetAllArticleWithAuthorQuery());
            return Ok(values);
        }
        [HttpGet("ArticleListWithAuthorsAndCategory")]
        public async Task<IActionResult> ArticleListWithAuthorsAndCategory()
        {
            var values = await _mediator.Send(new GetAllArticleWithAuthorAndCategoryQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticle(int id)
        {
            var value = await _mediator.Send(new GetArticleByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateArticle(CreateArticleCommand command)
        {

            await _mediator.Send(command);
            return Ok("Article başarıyla eklendi");

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveArticle(int id)
        {
            await _mediator.Send(new RemoveArticleCommand(id));
            return Ok("Article başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArticle(UpdateArticleCommand command)
        {
            await _mediator.Send(command);
            return Ok("Article başarıyla güncellendi");
        }

    }
}
