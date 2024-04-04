using BeldYazilim.Application.Enums;
using BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor;
using BeldYazilim.Application.Features.Mediator.Results.AppRoleResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class UpdateAppUserCommandHandler : IRequestHandler<UpdateAppUserCommand>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public UpdateAppUserCommandHandler(IRepository<AppUser> repository, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _repository = repository;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        //public async Task Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        //{
        //    var user = await _userManager.FindByIdAsync(request.AppUserID.ToString());

        //    var currentRoles = await _userManager.GetRolesAsync(user);
        //    foreach (var role in currentRoles)
        //    {
        //        await _userManager.RemoveFromRoleAsync(user, role);
        //    }

        //    if (!string.IsNullOrEmpty(request.RoleName))
        //    {
        //        await _userManager.AddToRoleAsync(user, request.RoleName);
        //    }


        //    user.FirstName = request.FirstName;
        //    user.Surname= request.Surname;
        //    user.District = request.District;
        //    user.About=request.About;
        //    user.RegistrationDate= request.RegistrationDate;
        //    user.City= request.City;
        //    user.ConfirmCode= request.ConfirmCode;
        //    user.Password = request.Password;

        //    await _userManager.UpdateAsync(user);


        //}
        public async Task Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.AppUserID.ToString());

            // Kullanıcının mevcut rollerini kaldır
            var currentRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in currentRoles)
            {
                await _userManager.RemoveFromRoleAsync(user, role);
            }

            // Yeni rolü ata
            if (Enum.IsDefined(typeof(RolesType), request.RoleId))
            {
                var roleName = Enum.GetName(typeof(RolesType), request.RoleId);
                await _userManager.AddToRoleAsync(user, roleName);
            }
            else
            {
                // Eğer belirtilen rol geçerli değilse varsayılan bir rol atayabiliriz
                var defaultRole = RolesType.Author; // Varsayılan rol
                var roleName = Enum.GetName(typeof(RolesType), defaultRole);
                await _userManager.AddToRoleAsync(user, roleName);
            }

            // Kullanıcının diğer özelliklerini güncelle
            user.FirstName = request.FirstName;
            user.Surname = request.Surname;
            user.District = request.District;
            user.About = request.About;
            user.City = request.City;
            //user.ConfirmCode = request.ConfirmCode;
            //user.Password = request.Password;

            // Kullanıcıyı güncelle
            await _userManager.UpdateAsync(user);
        }

    }
}
