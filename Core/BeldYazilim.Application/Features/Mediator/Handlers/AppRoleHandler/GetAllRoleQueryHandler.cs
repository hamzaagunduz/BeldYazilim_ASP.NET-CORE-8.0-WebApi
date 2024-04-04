using BeldYazilim.Application.Features.Mediator.Queries.AppRoleQueries;
using BeldYazilim.Application.Features.Mediator.Results.AppRoleResult;
using BeldYazilim.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AppRoleHandler
{
    public class GetAllRoleQueryHandler : IRequestHandler<GetAllRoleQuery, List<GetAllRoleQueryResult>>
    {
        private readonly RoleManager<AppRole> _roleManager;

        public GetAllRoleQueryHandler(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<List<GetAllRoleQueryResult>> Handle(GetAllRoleQuery request, CancellationToken cancellationToken)
        {
            var roles = await _roleManager.Roles.ToListAsync();

            // Role'leri GetAllRoleQueryResult nesnelerine dönüştür
            var roleResults = roles.Select(role => new GetAllRoleQueryResult
            {
                RoleId = role.Id,
                RoleName = role.Name
            }).ToList();

            return roleResults;

        }
    }
}
