using BeldYazilim.Application.Interfaces.AppUserInterfaces;
using BeldYazilim.Domain.Entities;
using BeldYazilim.Persistence.Context;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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

        public List<AppUser> GetAllUsersWithRole()
        {
            var values = _context.AppUsers.Include(x => x.ArticleAuthor).ToList();
            return values;
        }

        public AppUser GetUsersWithRoleById(int id)
        {
            var article = _context.Articles
                            .Include(a => a.ArticleAuthor)
                            .ThenInclude(aa => aa.AppUser)
                            .FirstOrDefault(a => a.ArticleID == id);

            return article?.ArticleAuthor?.AppUser;
        }
    }
}
