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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string District { get; set; }
        public string? About { get; set; }
        public string? Password { get; set; }

        public DateTime RegistrationDate { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public int ConfirmCode { get; set; }
    }
}
