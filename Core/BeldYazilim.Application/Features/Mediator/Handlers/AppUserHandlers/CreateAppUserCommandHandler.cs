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
        private readonly UserManager<AppUser> _userManager;




        public CreateAppUserCommandHandler(IRepository<AppUser> repository, UserManager<AppUser> userManager) 
        {
            _repository = repository;

            _userManager = userManager;
        }

        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {

            await _repository.CreateAsync(new AppUser
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

            });



        }





    }
}
