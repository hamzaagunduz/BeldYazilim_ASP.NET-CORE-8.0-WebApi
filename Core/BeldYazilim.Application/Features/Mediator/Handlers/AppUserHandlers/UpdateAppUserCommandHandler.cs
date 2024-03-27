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

        public async Task Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.AppUserID.ToString());

            var currentRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in currentRoles)
            {
                await _userManager.RemoveFromRoleAsync(user, role);
            }

            if (!string.IsNullOrEmpty(request.NewRole))
            {
                await _userManager.AddToRoleAsync(user, request.NewRole);
            }


            user.FirstName = request.FirstName;
            user.Surname= request.Surname;
            user.District = request.District;
            user.About=request.About;
            user.RegistrationDate= request.RegistrationDate;
            user.City= request.City;
            user.ConfirmCode= request.ConfirmCode;
            user.Password = request.Password;
            await _repository.UpdateAsync(user);

        }
    }
}
