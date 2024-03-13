using MediatR;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor
{
	public class LoginAppUserCommand : IRequest
	{
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
