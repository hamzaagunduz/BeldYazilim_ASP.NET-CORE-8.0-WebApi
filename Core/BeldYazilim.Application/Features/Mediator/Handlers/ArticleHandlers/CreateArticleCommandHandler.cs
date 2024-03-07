using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleHandlers
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IRepository<Article> _articleRepository;

        public CreateArticleCommandHandler(UserManager<AppUser> userManager, IRepository<Article> articleRepository)
        {
            _userManager = userManager;
            _articleRepository = articleRepository;
        }
    }
}
