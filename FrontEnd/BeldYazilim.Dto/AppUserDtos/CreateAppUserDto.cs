﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Dto.AppUserDtos
{
    public class CreateAppUserDto
    {

            public string FirstName { get; set; }
            public string UserName { get; set; }
            public string Surname { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }

    }
}
