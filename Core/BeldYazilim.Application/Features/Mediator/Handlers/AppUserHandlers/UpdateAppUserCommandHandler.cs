using BeldYazilim.Application.Features.Mediator.Commands.AppUserAuthor;
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
    public class UpdateAppUserCommandHandler : IRequestHandler<UpdateAppUserCommand>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly UserManager<AppUser> _userManager;

        public UpdateAppUserCommandHandler(IRepository<AppUser> repository, UserManager<AppUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;

        }


        public async Task Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AppUserID);
            values.FirstName = request.FirstName;
            values.Surname= request.Surname;
            values.District = request.District;
            values.About=request.About;
            values.RegistrationDate= request.RegistrationDate;
            values.City= request.City;
            values.ConfirmCode= request.ConfirmCode;
            values.Password = request.Password;
            await _repository.UpdateAsync(values);
        }
    }
}
