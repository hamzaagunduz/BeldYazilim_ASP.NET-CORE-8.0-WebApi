using BeldYazilim.Application.Features.Mediator.Commands.ArticleAuthorCommands;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleAuthorHandlers
{
    public class RemoveArticleAuthorCommandHandler : IRequestHandler<RemoveArticleAuthorCommand>
    {
        private readonly IRepository<ArticleAuthor> _repository;

        public RemoveArticleAuthorCommandHandler(IRepository<ArticleAuthor> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveArticleAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
