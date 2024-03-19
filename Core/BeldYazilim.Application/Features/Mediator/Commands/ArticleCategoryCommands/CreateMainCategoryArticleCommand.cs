﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCategoryCommands
{
    public class CreateMainCategoryArticleCommand:IRequest
    {
        public string Name { get; set; }

    }
}
