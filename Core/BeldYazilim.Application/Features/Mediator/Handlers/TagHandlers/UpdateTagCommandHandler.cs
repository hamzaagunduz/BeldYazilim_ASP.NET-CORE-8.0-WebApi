using BeldYazilim.Application.Features.Mediator.Commands.ArticleCategoryCommands;
using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
using BeldYazilim.Application.Features.Mediator.Commands.TagCommands;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.TagHandlers
{
    public class UpdateTagCommandHandler:IRequestHandler<UpdateTagCommand>
    {
        private readonly IRepository<Tag> _repository;

        public UpdateTagCommandHandler(IRepository<Tag> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.TagID);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);

        }
    }
}
