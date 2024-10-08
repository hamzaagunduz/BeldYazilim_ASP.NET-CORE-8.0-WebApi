﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor
{
    public class CreateAppUserCommand:IRequest
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string? imageUrl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
