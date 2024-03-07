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
    public class UpdateMainCategoryCommandHandler : IRequestHandler<UpdateMainCategoryCommand>
    {
        private readonly IRepository<MainCategory> _repository;

        public UpdateMainCategoryCommandHandler(IRepository<MainCategory> mainCategoryRepository)
        {
            _repository = mainCategoryRepository;
        }

        public async Task Handle(UpdateMainCategoryCommand request, CancellationToken cancellationToken)
        {
            var mainCategory = await _repository.GetByIdAsync(request.MainCategoryID);
            mainCategory.Name = request.UpdatedName;
            await _repository.UpdateAsync(mainCategory);
        }
    }



}
