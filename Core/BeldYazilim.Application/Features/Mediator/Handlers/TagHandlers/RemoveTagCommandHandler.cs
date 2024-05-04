using BeldYazilim.Application.Features.Mediator.Commands.ArticleCategoryCommands;
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
    internal class RemoveTagCommandHandler:IRequestHandler<RemoveTagCommand>
    {
        private readonly IRepository<Tag> _repository;

        public RemoveTagCommandHandler(IRepository<Tag> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);
            await _repository.RemoveAsync(value);
        }
    }
}
