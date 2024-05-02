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
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
    {
        private readonly IRepository<ArticleTag> _repository;

        public CreateTagCommandHandler(IRepository<ArticleTag> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            foreach (var tagId in request.TagID)
            {
                var articleTag = new ArticleTag
                {
                    ArticleID = request.ArticleID,
                    TagID = tagId
                };

                await _repository.CreateAsync(articleTag);
            }
        }
    }
}
