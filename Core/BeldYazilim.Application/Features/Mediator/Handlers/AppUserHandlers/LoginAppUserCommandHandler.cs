using BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor;
using BeldYazilim.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AppUserHandlers
{
	public class LoginAppUserCommandHandler : IRequestHandler<LoginAppUserCommand>
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

		public LoginAppUserCommandHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		public async Task Handle(LoginAppUserCommand request, CancellationToken cancellationToken)
		{
			
			var result = await _signInManager.PasswordSignInAsync(request.UserName, request.Password, false, true);
			if (result.Succeeded)
			{
				var user = await _userManager.FindByNameAsync(request.UserName);
			}
		}
	}
}
