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
    public class CreateArticleMainCategoryCommandHandler : IRequestHandler<CreateMainCategoryArticleCommand>
    {
        private readonly IRepository<ArticleMainCategory> _repository;

        public CreateArticleMainCategoryCommandHandler(IRepository<ArticleMainCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMainCategoryArticleCommand request, CancellationToken cancellationToken)
        {
            var mainCategory = new ArticleMainCategory
            {
                Name = request.Name
            };


            await _repository.CreateAsync(mainCategory);


        }




    }
}
