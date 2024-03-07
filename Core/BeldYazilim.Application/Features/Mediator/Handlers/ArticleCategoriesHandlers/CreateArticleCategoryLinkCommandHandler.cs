using BeldYazilim.Application.Features.Mediator.Commands.ArticleCategories;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleCategoriesHandlers
{
    public class CreateArticleCategoryLinkCommandHandler : IRequestHandler<CreateArticleCategoryLinkCommand, int>
    {
        private readonly IRepository<ArticleCategoryLink> _repository;

        public CreateArticleCategoryLinkCommandHandler(IRepository<ArticleCategoryLink> articleCategoryLinkRepository)
        {
            _repository = articleCategoryLinkRepository;
        }

        public async Task<int> Handle(CreateArticleCategoryLinkCommand request, CancellationToken cancellationToken)
        {
            var articleCategoryLink = new ArticleCategoryLink
            {
                ArticleID = request.ArticleID,
                MainCategoryID = request.MainCategoryID,
                SubcategoryID = request.SubcategoryID
            };

            await _repository.CreateAsync(articleCategoryLink);

            return articleCategoryLink.ArticleCategoryLinkID;
        }
    }

}
