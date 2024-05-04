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
    public class CreateFooterAboutCommandHandler:IRequestHandler<CreateFooterAboutCommand>
    {
        private readonly IRepository<FooterAbout> _repository;

        public CreateFooterAboutCommandHandler(IRepository<FooterAbout> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterAboutCommand request, CancellationToken cancellationToken)
        {
            var footerAbout = new FooterAbout
            {
                Content = request.Content
            };


            await _repository.CreateAsync(footerAbout);


        }
    }
}
