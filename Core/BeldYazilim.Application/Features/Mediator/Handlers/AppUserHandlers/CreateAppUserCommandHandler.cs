using BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
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

        private readonly IMediator _mediator;


        public CreateAppUserCommandHandler(IRepository<AppUser> repository, IRepository<ArticleAuthor> repositoryArticleAuthor, UserManager<AppUser> userManager, IMediator mediator)
        {
            _repository = repository;
            _repositoryArticleAuthor = repositoryArticleAuthor;
            _userManager = userManager;
            _mediator = mediator;
        }

        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            
                var newUser = new AppUser
                {
                    Name = request.Name,
					UserName = request.UserName,
					Surname = request.Surname,
                    RegistrationDate = DateTime.Now,
					Email = request.Email,
					Password =request.Password,
					ConfirmCode = 1,
				};

			IdentityResult result=await _userManager.CreateAsync(newUser,request.Password);

			

			var newArticleAuthor = new ArticleAuthor
				{
					AppUserID = newUser.Id,
					Name = "desiredName",
					Role = "Test"
				};

				await _repositoryArticleAuthor.CreateAsync(newArticleAuthor);

			






		}






	}
}
