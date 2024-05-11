using BeldYazilim.Application.Features.Mediator.Commands.AboutCommand;
using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
using BeldYazilim.Application.Features.Mediator.Queries.AboutQueries;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
using BeldYazilim.Application.Features.Mediator.Queries.FooterQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
        {

            await _mediator.Send(command);
            return Ok("About Güncellendi");

        }       
        [HttpGet]
        public async Task<IActionResult> GetAbout()
        {

            var values = await _mediator.Send(new GetAllAboutQuery());
            return Ok(values);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAbout(int id)
        {
            var values = await _mediator.Send(new GetAboutByIdQuery(id));
            return Ok(values);
        }
    }
}
