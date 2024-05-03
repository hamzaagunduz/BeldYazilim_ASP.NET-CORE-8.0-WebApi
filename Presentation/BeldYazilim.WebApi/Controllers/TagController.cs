using BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor;
using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
using BeldYazilim.Application.Features.Mediator.Commands.TagCommands;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
using BeldYazilim.Application.Features.Mediator.Queries.TagQueries;
using BeldYazilim.Persistence.Context;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TagController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagList()
        {
            var values = await _mediator.Send(new GetAllTagQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticleTag(CreateTagCommand command)
        {

            await _mediator.Send(command);
            return Ok("TagCommand başarıyla eklendi");

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagById(int id)
        {
            var values = await _mediator.Send(new GetTagByIdQuery(id));
            return Ok(values);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArticle(UpdateArticleTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Article başarıyla güncellendi");
        }
    }
}
