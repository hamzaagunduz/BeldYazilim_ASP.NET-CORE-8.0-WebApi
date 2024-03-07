using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleCommandHandlers
{
    public class RemoveArticleCommandHandler : IRequestHandler<RemoveArticleCommand>
    {
        private readonly IRepository<Article> _repository;

        public RemoveArticleCommandHandler(IRepository<Article> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveArticleCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
