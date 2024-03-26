using BeldYazilim.Application.Enums;
using BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IRepository<ArticleAuthor> _repositoryArticleAuthor;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        private readonly IMediator _mediator;


        public CreateAppUserCommandHandler(IRepository<AppUser> repository, IRepository<ArticleAuthor> repositoryArticleAuthor, UserManager<AppUser> userManager, IMediator mediator, RoleManager<AppRole> roleManager)
        {
            _repository = repository;
            _repositoryArticleAuthor = repositoryArticleAuthor;
            _userManager = userManager;
            _mediator = mediator;
            _roleManager = roleManager;
        }


        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            
                var newUser = new AppUser
                {
                    FirstName = request.FirstName,
					UserName = request.UserName,
					Surname = request.Surname,
                    RegistrationDate = DateTime.Now,
					Email = request.Email,
					Password =request.Password,
					ConfirmCode = 1,
                    
				};

			IdentityResult result=await _userManager.CreateAsync(newUser,request.Password);

            var adminRole = await _roleManager.FindByNameAsync("Admin");

            if (adminRole == null)
            {
                adminRole = new AppRole { Name = "Admin" };
                await _roleManager.CreateAsync(adminRole);
            }

            var addToRoleResult = await _userManager.AddToRoleAsync(newUser, adminRole.Name);

            var userRoles = await _userManager.GetRolesAsync(newUser);
            var rolesString = string.Join(", ", userRoles);


            var newArticleAuthor = new ArticleAuthor
            {
                AppUserID = newUser.Id,
                Name = newUser.FirstName,
                Role = rolesString
            };

			await _repositoryArticleAuthor.CreateAsync(newArticleAuthor);

			






		}






	}
}
