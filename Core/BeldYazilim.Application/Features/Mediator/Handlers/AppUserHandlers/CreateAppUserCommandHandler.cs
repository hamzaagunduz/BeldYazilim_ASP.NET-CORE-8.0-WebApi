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
                    Surname = request.Surname,
                    District = request.District,
                    City = request.City,
                    About = request.About,
                    RegistrationDate = DateTime.Now,
                    ImageUrl = request.ImageUrl,
                    ConfirmCode = request.ConfirmCode,
                    Password = request.Password,
                };

                await _repository.CreateAsync(newUser);


                await _repositoryArticleAuthor.CreateAsync(new ArticleAuthor
                {
                    AppUserID = newUser.Id,
                    Name = request.Name,
                    Role="Test"
                });



        }






    }
}
