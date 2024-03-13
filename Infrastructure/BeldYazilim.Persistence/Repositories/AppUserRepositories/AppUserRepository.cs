using BeldYazilim.Application.Interfaces.AppUserInterfaces;
using BeldYazilim.Domain.Entities;
using BeldYazilim.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Persistence.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly BeldYazilimContext _context;
        public AppUserRepository(BeldYazilimContext context)
        {
            _context = context;
        }
        public Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
