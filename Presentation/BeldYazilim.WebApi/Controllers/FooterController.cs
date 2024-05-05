using BeldYazilim.Application.Features.Mediator.Commands.FooterCommand;
using BeldYazilim.Application.Features.Mediator.Commands.TagCommands;
using BeldYazilim.Application.Features.Mediator.Queries.FooterQueries;
using BeldYazilim.Application.Features.Mediator.Queries.TagQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FooterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> FooterAbout()
        {
            var values = await _mediator.Send(new GetFooterAboutQuery());
            return Ok(values);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateArticle(UpdateFooterAboutCommand command)
        {
            await _mediator.Send(command);
            return Ok("ArticleTag başarıyla güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAbout(int id)
        {
            var values = await _mediator.Send(new GetByIdFooterAboutQuery(id));
            return Ok(values);
        }
    }
}
