using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
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

        public UpdateArticleCommandHandler(IRepository<Article> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ArticleID);
            values.Title = request.Title;
            values.Content = request.Content;
            values.CreationTime = request.CreationTime;
            values.ClickCount = request.ClickCount;
            values.BigImageUrl = request.BigImageUrl;
            values.Rating = request.Rating;
            //values.ArticleAuthorID = request.ArticleAuthorID;
            await _repository.UpdateAsync(values);
        }
    }
}
