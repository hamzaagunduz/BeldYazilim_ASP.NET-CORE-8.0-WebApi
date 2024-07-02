using BeldYazilim.Application.Features.Mediator.Queries.AppRoleQueries;
using BeldYazilim.Application.Features.Mediator.Results.AppRoleResult;
using BeldYazilim.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;


namespace BeldYazilim.Application.Features.Mediator.Handlers.AppRoleHandler
{
    public class GetAppRoleQueryHandler : IRequestHandler<GetAppRoleQuery, List<GetAppRoleQueryResult>>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public GetAppRoleQueryHandler(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<List<GetAppRoleQueryResult>> Handle(GetAppRoleQuery request, CancellationToken cancellationToken)
        {
            var users = await _userManager.Users.ToListAsync();
            var roles = await _roleManager.Roles.ToListAsync();

            // Her kullanıcı için rolleri alıp GetAppRoleQueryResult nesnelerini oluşturmak için LINQ sorgusu
            var result = new List<GetAppRoleQueryResult>();
            foreach (var user in users)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                foreach (var roleName in userRoles)
                {
                    var role = roles.FirstOrDefault(r => r.Name == roleName);
                    if (role != null)
                    {
                        result.Add(new GetAppRoleQueryResult
                        {
                            UserId = user.Id,
                            UserName = user.UserName,
                            SurName = user.Surname,
                            Email = user.Email,
                            RoleId = role.Id,
                            RoleName = role.Name
                        });
                    }
                }
            }

            return result;
        }
    }
}
