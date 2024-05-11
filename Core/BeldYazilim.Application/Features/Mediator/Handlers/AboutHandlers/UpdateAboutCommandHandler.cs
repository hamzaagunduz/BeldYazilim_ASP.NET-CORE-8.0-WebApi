using BeldYazilim.Application.Features.Mediator.Commands.AboutCommand;
using BeldYazilim.Application.Helpers;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand>
    {
        private readonly IRepository<About> _repository;
        private readonly IImageHelper imageHelper;

        public UpdateAboutCommandHandler(IRepository<About> repository, IImageHelper imageHelper)
        {
            _repository = repository;
            this.imageHelper = imageHelper;
        }
        public async Task Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AboutID);
            var imageUpload = await imageHelper.Upload(request.Title, request.Photo);
            var imageUpload2 = await imageHelper.Upload(request.Title2, request.Photo2);
            values.Title = request.Title;
            values.Content = request.Content;
            values.Title2 = request.Title2;
            values.Content2 = request.Content2;
            values.ImageUrl = imageUpload.FullName;
            values.ImageUrl2 = imageUpload2.FullName;
            await _repository.UpdateAsync(values);

        }
    }
}
