using BeldYazilim.Application.Features.Mediator.Queries.ArticleAuthorQueries;
using BeldYazilim.Application.Features.Mediator.Queries.TagQueries;
using BeldYazilim.Application.Features.Mediator.Results.ArticleAuthorResult;
using BeldYazilim.Application.Features.Mediator.Results.TagResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BeldYazilim.Application.Features.Mediator.Handlers.TagHandlers
{
    public class GetAllTagQueryHandler:IRequestHandler<GetAllTagQuery,List<GetAllTagQueryResult>>
    {
        private readonly IRepository<Tag> _repository;

        public GetAllTagQueryHandler(IRepository<Tag> repository)
        {
            _repository = repository;
        }
        
        public async Task<List<GetAllTagQueryResult>> Handle(GetAllTagQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAllTagQueryResult
            {
                TagID = x.TagID,
                Name = x.Name,

            }).ToList();
        }
    }
}

