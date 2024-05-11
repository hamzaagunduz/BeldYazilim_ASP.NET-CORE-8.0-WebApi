using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
using BeldYazilim.Application.Helpers;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleHandlers
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, Unit>
    {
        private readonly IRepository<Article> _repository;
        private readonly UserManager<AppUser> _userManager;
        private readonly IImageHelper imageHelper;
        public CreateArticleCommandHandler(IRepository<Article> repository, UserManager<AppUser> userManager, IImageHelper imageHelper)
        {
            _repository = repository;
            _userManager = userManager;
            this.imageHelper = imageHelper;
        }

        public async Task<Unit> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var imageUpload = await imageHelper.Upload(request.Title, request.Photo);
            var article = new Article
            {
                Title = request.Title,
                Content = request.Content,
                CreationTime = DateTime.Now,
                ClickCount = 0,
                BigImageUrl = imageUpload.FullName,
                Rating = 1,
                ArticleMainCategoryID = request.MainCategoryId,
                ArticleAuthorID = 8
            };

            await _repository.CreateAsync(article);

            return Unit.Value;
        }


    }
}