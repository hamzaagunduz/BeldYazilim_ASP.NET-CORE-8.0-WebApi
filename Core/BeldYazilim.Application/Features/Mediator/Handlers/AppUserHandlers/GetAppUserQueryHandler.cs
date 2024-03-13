using BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries;
using BeldYazilim.Application.Features.Mediator.Results.AppUserResult;
using BeldYazilim.Application.Features.Mediator.Results.ArticleAuthorResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetAppUserQueryHandler : IRequestHandler<GetAppUserQuery, List<GetAppUserQueryResult>>
    {
        private readonly IRepository<AppUser> _repository;

        public GetAppUserQueryHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAppUserQueryResult>> Handle(GetAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAppUserQueryResult
            {
                AppUserID = x.Id,
                City = x.City,
                Name = x.FirstName,
                Surname = x.Surname,
                District = x.District,
                About = x.About,
                RegistrationDate = x.RegistrationDate,
                ImageUrl = x.ImageUrl,
                ConfirmCode = x.ConfirmCode,


            }).ToList();
        }
    }
}
