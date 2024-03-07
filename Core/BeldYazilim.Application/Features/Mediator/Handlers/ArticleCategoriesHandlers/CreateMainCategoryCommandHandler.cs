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
    public class CreateMainCategoryCommandHandler : IRequestHandler<CreateMainCategoryCommand, int>
    {
        private readonly IRepository<MainCategory> _repository;

        public CreateMainCategoryCommandHandler(IRepository<MainCategory> mainCategoryRepository)
        {
            _repository = mainCategoryRepository;
        }

        public async Task<int> Handle(CreateMainCategoryCommand request, CancellationToken cancellationToken)
        {
            var mainCategory = new MainCategory
            {
                Name = request.Name
            };

            await _repository.CreateAsync(mainCategory);

            return mainCategory.MainCategoryID;
        }
    }

}
