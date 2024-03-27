using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
using BeldYazilim.Application.Helpers;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleCommandHandlers
{
    public class UpdateArticleCommandHandler : IRequestHandler<UpdateArticleCommand>
    {
        private readonly IRepository<Article> _repository;
        private readonly IImageHelper imageHelper;

        public UpdateArticleCommandHandler(IRepository<Article> repository, IImageHelper imageHelper)
        {
            _repository = repository;
            this.imageHelper = imageHelper;
        }
        public async Task Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ArticleID);
            var imageUpload = await imageHelper.Upload(request.Title, request.Photo);
            values.Title = request.Title;
            values.Content = request.Content;
            values.CreationTime = request.CreationTime;
            values.ClickCount = request.ClickCount;
            values.BigImageUrl = imageUpload.FullName;
            values.Rating = request.Rating;
            values.ArticleMainCategoryID = request.MainCategoryId;
            //values.ArticleAuthorID = request.ArticleAuthorID;
            await _repository.UpdateAsync(values);
        }
    }
}
