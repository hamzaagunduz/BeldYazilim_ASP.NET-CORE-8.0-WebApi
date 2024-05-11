using BeldYazilim.Application.Features.Mediator.Commands.AboutCommand;
using BeldYazilim.Application.Features.Mediator.Commands.FeaturesCommand;
using BeldYazilim.Application.Features.Mediator.Queries.AboutQueries;
using BeldYazilim.Application.Features.Mediator.Queries.FeaturesQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FeatureController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateFeaturesCommand command)
        {

            await _mediator.Send(command);
            return Ok("About Güncellendi");

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAbout(int id)
        {
            var values = await _mediator.Send(new GetByIdFeaturesQuery(id));
            return Ok(values);
        }
    }
}
