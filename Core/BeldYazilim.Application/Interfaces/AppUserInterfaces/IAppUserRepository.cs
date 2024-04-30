using BeldYazilim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Interfaces.AppUserInterfaces
{
    public interface IAppUserRepository
    {
        public List<AppUser> GetAllUsersWithRole();
        public AppUser GetUsersWithRoleById(int id);
    }
}
