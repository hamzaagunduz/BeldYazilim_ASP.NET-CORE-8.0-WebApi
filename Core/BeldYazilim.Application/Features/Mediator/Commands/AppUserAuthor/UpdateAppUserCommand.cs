using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor
{
    public class UpdateAppUserCommand:IRequest
    {
        public int AppUserID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int RoleId { get; set; }
        public string? District { get; set; }
        public string? About { get; set; }
        //public string? Password { get; set; }
        public string? City { get; set; }
        //public int ConfirmCode { get; set; }
    }
}
