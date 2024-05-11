using BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor;
using BeldYazilim.Application.Features.Mediator.Handlers.AppUserHandlers;
using BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries;
using BeldYazilim.Application.Tools;
using BeldYazilim.Persistence.Context;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly BeldYazilimContext _context;


        public AppUserController(IMediator mediator, BeldYazilimContext context) 
        {
            _mediator = mediator;

            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> AppUserList()
        {
            var values = await _mediator.Send(new GetAppUserQuery());
            return Ok(values);
        }


        [HttpGet("GetAllUsersWithRole")]
        public async Task<IActionResult> GetAllUsersWithRole()
        {
            var values = await _mediator.Send(new GetAllUsersWithRoleQuery());
            return Ok(values);
        }   
        [HttpGet("GetUsersWithAdminRoleQuery")]
        public async Task<IActionResult> GetUsersWithAdminRoleQuery()
        {
            var values = await _mediator.Send(new GetUsersWithAdminRoleQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppUser(int id)
        {
            var value = await _mediator.Send(new GetAppUserByIdQuery(id));
            return Ok(value);
        }
        [HttpGet("user-with-role-byArticleId/{id}")] // İkinci endpoint
        public async Task<IActionResult> GetUsersWithRoleByIdQuery(int id)
        {
            var value = await _mediator.Send(new GetUsersWithRoleByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAppUser(CreateAppUserCommand command)
        {
          
                await _mediator.Send(command);
                return Ok("AppUser başarıyla eklendi");
    
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAppUser(int id)
        {
            await _mediator.Send(new RemoveAppUserCommand(id));
            return Ok("AppUser başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAppUser(UpdateAppUserCommand command)
        {
            await _mediator.Send(command);
            return Ok("AppUser başarıyla güncellendi");
        }
        //[HttpPost("AppUserLogin")]
        //public async Task<IActionResult> AppUserLogin(LoginAppUserCommand command)
        //{

        //	await _mediator.Send(command);
        //	return Ok("Login Olundu");

        //}
        [HttpPost("LoginToken")]
        public async Task<IActionResult> LoginToken(GetCheckAppUserQuery query)
        {
            var values = await _mediator.Send(query);
            if (values.IsExist)
            {
                return Created("", JwtTokenGenerator.GenerateToken(values));
            }
            else
            {
                return BadRequest("Kullanıcı adı veya şifre hatalıdır");
            }
        }


    }
}
