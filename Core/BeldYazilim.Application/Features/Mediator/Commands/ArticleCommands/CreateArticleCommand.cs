﻿using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands
{
    public class CreateArticleCommand:IRequest<Unit>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int MainCategoryId { get; set; }

        public DateTime CreationTime { get; set; }
        public int ClickCount { get; set; }
        public string BigImageUrl { get; set; }
        public int? Rating { get; set; }
        //public AppUser User { get; set; }
    }
}
