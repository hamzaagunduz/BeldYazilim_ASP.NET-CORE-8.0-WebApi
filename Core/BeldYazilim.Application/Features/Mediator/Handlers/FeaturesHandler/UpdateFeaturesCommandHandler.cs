using BeldYazilim.Application.Features.Mediator.Commands.FeaturesCommand;
using BeldYazilim.Application.Features.Mediator.Commands.FooterCommand;
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
    internal class UpdateFeaturesCommandHandler:IRequestHandler<UpdateFeaturesCommand>
    {
        private readonly IRepository<Feature> _repository;

        public UpdateFeaturesCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFeaturesCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FeatureID);
            values.Title = request.Title;
            values.Title2 = request.Title2;
            values.Title3 = request.Title3;
            values.Content = request.Content;
            values.Content2 = request.Content2;
            values.Content3 = request.Content3;
            await _repository.UpdateAsync(values);

        }
    }
}
