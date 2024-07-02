using BeldYazilim.Application.Features.Mediator.Queries.AboutQueries;
using BeldYazilim.Application.Features.Mediator.Queries.TagQueries;
using BeldYazilim.Application.Features.Mediator.Results.AboutResult;
using BeldYazilim.Application.Features.Mediator.Results.TagResult;
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
    public class GetAllAboutQueryHandler:IRequestHandler<GetAllAboutQuery,List<GetAllAboutQueryResult>>
    {
        private readonly IRepository<About> _repository;

        public GetAllAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllAboutQueryResult>> Handle(GetAllAboutQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAllAboutQueryResult
            {
                AboutID=x.AboutID, Title=x.Title,
                Content=x.Content,
                Content2 = x.Content2,
                ImageUrl = x.ImageUrl,
                ImageUrl2 = x.ImageUrl2,
                Title2 = x.Title2,
            }).ToList();
        }
    }
}
