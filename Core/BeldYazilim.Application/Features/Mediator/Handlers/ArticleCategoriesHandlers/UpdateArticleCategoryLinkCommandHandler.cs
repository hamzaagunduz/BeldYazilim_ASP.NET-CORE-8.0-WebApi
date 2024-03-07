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
    public class UpdateArticleCategoryLinkCommandHandler : IRequestHandler<UpdateArticleCategoryLinkCommand>
    {
        private readonly IRepository<ArticleCategoryLink> _articleCategoryLinkRepository;

        public UpdateArticleCategoryLinkCommandHandler(IRepository<ArticleCategoryLink> articleCategoryLinkRepository)
        {
            _articleCategoryLinkRepository = articleCategoryLinkRepository;
        }

        public async Task Handle(UpdateArticleCategoryLinkCommand request, CancellationToken cancellationToken)
        {
            var articleCategoryLink = await _articleCategoryLinkRepository.GetByIdAsync(request.ArticleCategoryLinkID);

            articleCategoryLink.ArticleID = request.UpdatedArticleID;
            articleCategoryLink.MainCategoryID = request.UpdatedMainCategoryID;
            articleCategoryLink.SubcategoryID = request.UpdatedSubcategoryID;


            await _articleCategoryLinkRepository.UpdateAsync(articleCategoryLink);

        }
    }

}
