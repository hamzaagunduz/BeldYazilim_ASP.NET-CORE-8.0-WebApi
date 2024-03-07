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
    public class CreateSubcategoryCommandHandler : IRequestHandler<CreateSubcategoryCommand, int>
    {
        private readonly IRepository<Subcategory> _repository;

        public CreateSubcategoryCommandHandler(IRepository<Subcategory> subcategoryRepository)
        {
            _repository = subcategoryRepository;
        }

        public async Task<int> Handle(CreateSubcategoryCommand request, CancellationToken cancellationToken)
        {
            var subcategory = new Subcategory
            {
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                MainCategoryID = request.MainCategoryID
            };

            await _repository.CreateAsync(subcategory);

            return subcategory.SubCategoryID;
        }
    }

}
