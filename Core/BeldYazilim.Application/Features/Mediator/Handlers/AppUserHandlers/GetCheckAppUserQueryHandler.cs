using BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries;
using BeldYazilim.Application.Features.Mediator.Results.AppUserResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public GetCheckAppUserQueryHandler(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAppUserQueryResult();
            //var user = await _appUserRepository.GetByFilterAsync(x => x.UserName == request.UserName && x.Password == request.Password);
            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null)
            {
                values.IsExist = false;
            }
            else
            {
                var passwordVerificationResult = _userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);

                if (passwordVerificationResult == PasswordVerificationResult.Success)
                    values.IsExist = true;
                    values.UserName = user.UserName;
                    values.Id = user.Id;
                    var userRoles = await _userManager.GetRolesAsync(user);
                    var roleName = userRoles.First(); // Kullanıcının ilk rolünü alıyoruz, eğer birden fazla rolü varsa bunu uygun bir şekilde ele almalısınız.
                    var appRole = await _roleManager.FindByNameAsync(roleName);
                    if (appRole != null)
                    {
                        values.Role = appRole.Name;
                    }
            }
            return values;
        }
    }
}
