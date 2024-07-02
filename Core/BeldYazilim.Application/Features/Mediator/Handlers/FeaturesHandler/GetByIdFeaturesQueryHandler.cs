using BeldYazilim.Application.Features.Mediator.Queries.FeaturesQueries;
using BeldYazilim.Application.Features.Mediator.Queries.FooterQueries;
using BeldYazilim.Application.Features.Mediator.Results.FeaturesResult;
using BeldYazilim.Application.Features.Mediator.Results.FooterResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.FeaturesHandler
{
    public class GetByIdFeaturesQueryHandler:IRequestHandler<GetByIdFeaturesQuery, GetByIdFeaturesQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetByIdFeaturesQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetByIdFeaturesQueryResult> Handle(GetByIdFeaturesQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.id);
            return new GetByIdFeaturesQueryResult
            {
                FeatureID=values.FeatureID,
                Title=values.Title,
                Title2=values.Title2,
                Title3=values.Title3,
                Content = values.Content,
                Content2 = values.Content2,
                Content3 = values.Content3,
            };
        }
    }
}
