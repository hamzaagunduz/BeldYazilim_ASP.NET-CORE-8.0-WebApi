using BeldYazilim.Application.Features.Mediator.Commands.ArticleCategoryCommands;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleCategoryHandlers
{
    public class RemoveArticleMainCategoryCommandHandler : IRequestHandler<RemoveMainCategoryArticleCommand>
    {
        private readonly IRepository<ArticleMainCategory> _repository;

        public RemoveArticleMainCategoryCommandHandler(IRepository<ArticleMainCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveMainCategoryArticleCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
