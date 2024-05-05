using BeldYazilim.Application.Features.Mediator.Commands.ArticleAuthorCommands;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleAuthorQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleAuthorsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ArticleAuthorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ArticleAuthorList()
        {
            var values = await _mediator.Send(new GetArticleAuthorQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleAuthor(int id)
        {
            var value = await _mediator.Send(new GetArticleAuthorByIdQuery(id));
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveArticleAuthor(int id)
        {
            await _mediator.Send(new RemoveArticleAuthorCommand(id));
            return Ok("ArticleAuthor başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArticleAuthor(UpdateArticleAuthorCommand command)
        {
            await _mediator.Send(command);
            return Ok("ArticleAuthor başarıyla güncellendi");
        }







    }
}
