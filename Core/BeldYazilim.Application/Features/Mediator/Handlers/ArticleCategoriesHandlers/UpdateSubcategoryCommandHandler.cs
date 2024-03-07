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
    public class UpdateSubcategoryCommandHandler : IRequestHandler<UpdateSubcategoryCommand>
    {
        private readonly IRepository<Subcategory> _repository;

        public UpdateSubcategoryCommandHandler(IRepository<Subcategory> subcategoryRepository)
        {
            _repository = subcategoryRepository;
        }

        public async Task Handle(UpdateSubcategoryCommand request, CancellationToken cancellationToken)
        {
            var subcategory = await _repository.GetByIdAsync(request.SubCategoryID);
            subcategory.Name = request.UpdatedName;
            subcategory.MainCategoryID = request.MainCategoryID;
            await _repository.UpdateAsync(subcategory);

        }
    }

}
