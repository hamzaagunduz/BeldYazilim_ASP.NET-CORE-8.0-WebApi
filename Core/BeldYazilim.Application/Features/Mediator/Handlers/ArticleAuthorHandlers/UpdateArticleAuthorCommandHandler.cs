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
    public class UpdateArticleAuthorCommandHandler : IRequestHandler<UpdateArticleAuthorCommand>
    {
        private readonly IRepository<ArticleAuthor> _repository;

        public UpdateArticleAuthorCommandHandler(IRepository<ArticleAuthor> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateArticleAuthorCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ArticleAuthorID);
            values.Name = request.Name;
            values.Role=request.Role;
            values.AppUserID=request.AppUserID;
            await _repository.UpdateAsync(values);
        }
    }
}
