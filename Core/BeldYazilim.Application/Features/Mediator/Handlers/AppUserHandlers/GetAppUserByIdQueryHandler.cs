using BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries;
using BeldYazilim.Application.Features.Mediator.Results.AppUserResult;
using BeldYazilim.Application.Features.Mediator.Results.ArticleAuthorResult;
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
    public class GetAppUserByIdQueryHandler : IRequestHandler<GetAppUserByIdQuery, GetAppUserByIdQueryResult>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IRepository<AppUser> _repository;

        public GetAppUserByIdQueryHandler(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IRepository<AppUser> repository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _repository = repository;
        }

        public async Task<GetAppUserByIdQueryResult> Handle(GetAppUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.Id.ToString());
            if (user == null)
            {
                // Kullanıcı bulunamadı, uygun bir işlem yapılabilir veya null döndürülebilir
                return null;
            }

            // Kullanıcının rollerini alalım
            var roles = await _userManager.GetRolesAsync(user);
            var roleName = roles.FirstOrDefault();

            // Kullanıcının ilk rolünün ID'sini alalım
            var roleId = 0;
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role != null)
            {
                roleId = role.Id;
            }

            // GetAppUserByIdQueryResult nesnesini dolduralım
            var result = new GetAppUserByIdQueryResult
            {
                AppUserID = user.Id,
                RoleId = roleId,
                FirstName = user.FirstName,
                Email=user.Email,
                UserName = user.UserName,
                Surname = user.Surname,
                RoleName = roleName,
                District = user.District,
                About = user.About,
                RegistrationDate = user.RegistrationDate,
                City = user.City,
                ImageUrl = user.ImageUrl,
                ConfirmCode = user.ConfirmCode,
                Password=user.Password
            };

            return result;
        }

    }
}
