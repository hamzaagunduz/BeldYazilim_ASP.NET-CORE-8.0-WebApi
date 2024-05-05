﻿using BeldYazilim.Application.Features.Mediator.Commands.ArticleCategoryCommands;
using BeldYazilim.Application.Features.Mediator.Commands.TagCommands;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.TagHandlers
{
    public class CreateNewTagCommandHandler:IRequestHandler<CreateNewTagCommand>
    {
        private readonly IRepository<Tag> _repository;

        public CreateNewTagCommandHandler(IRepository<Tag> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateNewTagCommand request, CancellationToken cancellationToken)
        {
            var mainCategory = new Tag
            {
                Name = request.Name
            };


            await _repository.CreateAsync(mainCategory);


        }
    }
}