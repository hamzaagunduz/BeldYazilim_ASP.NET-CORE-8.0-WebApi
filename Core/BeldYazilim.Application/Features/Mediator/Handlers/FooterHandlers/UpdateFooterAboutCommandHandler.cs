using BeldYazilim.Application.Features.Mediator.Commands.FooterCommand;
using BeldYazilim.Application.Features.Mediator.Commands.TagCommands;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.FooterHandlers
{
    public class UpdateFooterAboutCommandHandler:IRequestHandler<UpdateFooterAboutCommand>
    {
        private readonly IRepository<FooterAbout> _repository;

        public UpdateFooterAboutCommandHandler(IRepository<FooterAbout> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAboutCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FooterAboutID);
            values.Content = request.Content;
            await _repository.UpdateAsync(values);

        }
    }
}
