using BeldYazilim.Application.Enums;
using BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor;
using BeldYazilim.Application.Features.Mediator.Results.AppRoleResult;
using BeldYazilim.Application.Helpers;
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
        private readonly IRepository<ArticleAuthor> _repositoryArticleAuthor;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IImageHelper imageHelper;

        public UpdateAppUserCommandHandler(IRepository<ArticleAuthor> repositoryArticleAuthor, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IImageHelper imageHelper)
        {
            _repositoryArticleAuthor = repositoryArticleAuthor;
            _userManager = userManager;
            _roleManager = roleManager;
            this.imageHelper = imageHelper;
        }



        
        public async Task Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.AppUserID.ToString());
            var articleAuthor = await _repositoryArticleAuthor.GetByIdAsync(request.AppUserID);

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
                articleAuthor.Role=roleName;
            }
            else
            {
                // Eğer belirtilen rol geçerli değilse varsayılan bir rol atayabiliriz
                var defaultRole = RolesType.Author; // Varsayılan rol
                var roleName = Enum.GetName(typeof(RolesType), defaultRole);
                articleAuthor.Role = roleName;

                await _userManager.AddToRoleAsync(user, roleName);
            }
            var imageUpload = await imageHelper.Upload(request.FirstName, request.Photo);

            // Kullanıcının diğer özelliklerini güncelle
            user.FirstName = request.FirstName;
            user.Surname = request.Surname;
            user.District = request.District;
            user.About = request.About;
            user.City = request.City;
            user.ImageUrl = imageUpload.FullName;

            articleAuthor.Name = request.FirstName;


            // Kullanıcıyı güncelle
            await _repositoryArticleAuthor.UpdateAsync(articleAuthor);

            await _userManager.UpdateAsync(user);
           


        }

    }
}
