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
    public class UpdateArticleMainCategoryCommandHandler :IRequestHandler<UpdateMainCategoryArticleCommand>
    {
        private readonly IRepository<ArticleMainCategory> _repository;

        public UpdateArticleMainCategoryCommandHandler(IRepository<ArticleMainCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateMainCategoryArticleCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.articleMainCategoryID);
            values.Name = request.name;
            values.ArticleMainCategoryID=request.articleMainCategoryID;
            await _repository.UpdateAsync(values);

        }
    }
}
