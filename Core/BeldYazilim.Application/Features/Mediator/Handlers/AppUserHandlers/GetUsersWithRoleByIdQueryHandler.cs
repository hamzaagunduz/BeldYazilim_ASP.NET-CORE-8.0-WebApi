using BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries;
using BeldYazilim.Application.Features.Mediator.Results.AppUserResult;
using BeldYazilim.Application.Interfaces.AppUserInterfaces;
using BeldYazilim.Domain.Entities;
using BeldYazilim.Dto.AppUserDtos;
using MediatR;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetUsersWithRoleByIdQueryHandler : IRequestHandler<GetUsersWithRoleByIdQuery, GetUsersWithRoleByIdQueryResult>
    {
        private readonly IAppUserRepository _repository;

        public GetUsersWithRoleByIdQueryHandler(IAppUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetUsersWithRoleByIdQueryResult> Handle(GetUsersWithRoleByIdQuery request, CancellationToken cancellationToken)
        {
            var user = _repository.GetUsersWithRoleById(request.id);
            var result = new GetUsersWithRoleByIdQueryResult
            {
            
                Id = user.Id,
                FirstName = user.FirstName,
                Email=user.Email,
                Surname = user.Surname,
                About = user.About,
                registrationDate = user.RegistrationDate,
                ImageUrl = user.ImageUrl,
                Role=user.ArticleAuthor.Role
            };
            return result;
        }
    }
}
