using BeldYazilim.Application.Features.Mediator.Commands.ArticleAuthorCommands;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleAuthorHandlers
{
    public class CreateArticleAuthorCommandHandler : IRequestHandler<CreateArticleAuthorCommand>
    {
        private readonly IRepository<ArticleAuthor> _repository;

        public CreateArticleAuthorCommandHandler(IRepository<ArticleAuthor> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateArticleAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ArticleAuthor
            {
                AppUserID = 1,
                Name = request.Name,
                Role = request.Role,
            }) ;
        }
    }
}
