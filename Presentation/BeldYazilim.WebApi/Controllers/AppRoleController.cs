using BeldYazilim.Application.Features.Mediator.Handlers.AppRoleHandler;
using BeldYazilim.Application.Features.Mediator.Queries.AppRoleQueries;
using BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries;
using BeldYazilim.Persistence.Context;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppRoleController : ControllerBase
    {
        private readonly IMediator _mediator;


        public AppRoleController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> AppRoleList()
        {
            var values = await _mediator.Send(new GetAppRoleQuery());
            return Ok(values);
        }      
        [HttpGet("GetAllRole")]
        public async Task<IActionResult> GetAllRole()
        {
            var values = await _mediator.Send(new GetAllRoleQuery());
            return Ok(values);
        }
    }
}
