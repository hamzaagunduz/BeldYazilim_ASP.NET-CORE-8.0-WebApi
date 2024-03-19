using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
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
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand,Unit>
    {
        private readonly IRepository<Article> _repository;
        private readonly UserManager<AppUser> _userManager;

        public CreateArticleCommandHandler(IRepository<Article> repository, UserManager<AppUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task<Unit> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var article = new Article
            {
                Title = request.Title,
                Content = request.Content,
                CreationTime = request.CreationTime,
                ClickCount = request.ClickCount,
                BigImageUrl = request.BigImageUrl,
                Rating = request.Rating,
                ArticleMainCategoryID=request.MainCategoryId
                //ArticleAuthorID = request.User.ArticleAuthor.ArticleAuthorID
            };

            await _repository.CreateAsync(article);

            return Unit.Value;
        }


    }
}
