using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Results.AppUserResult
{
    public class GetUsersWithRoleByIdQueryResult
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public DateTime registrationDate { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }
    }
}
