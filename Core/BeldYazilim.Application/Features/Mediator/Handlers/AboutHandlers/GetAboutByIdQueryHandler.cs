using BeldYazilim.Application.Features.Mediator.Queries.AboutQueries;
using BeldYazilim.Application.Features.Mediator.Queries.FooterQueries;
using BeldYazilim.Application.Features.Mediator.Results.AboutResult;
using BeldYazilim.Application.Features.Mediator.Results.FooterResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler:IRequestHandler<GetAboutByIdQuery, GetAboutByIdQueryResult>
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
        {
            var x = await _repository.GetByIdAsync(request.id);
            return new GetAboutByIdQueryResult
            {
                AboutID = x.AboutID,
                Title = x.Title,
                Content = x.Content,
                Content2 = x.Content2,
                ImageUrl = x.ImageUrl,
                ImageUrl2 = x.ImageUrl2,
                Title2 = x.Title2,
            };
        }
    }
}
