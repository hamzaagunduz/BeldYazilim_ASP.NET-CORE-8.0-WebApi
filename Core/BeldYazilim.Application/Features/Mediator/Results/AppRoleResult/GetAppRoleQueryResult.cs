using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Results.AppRoleResult
{
    public class GetAppRoleQueryResult
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string SurName { get; set; }
        public string RoleName { get; set; }
        public string Email { get; set; }
    }
}
