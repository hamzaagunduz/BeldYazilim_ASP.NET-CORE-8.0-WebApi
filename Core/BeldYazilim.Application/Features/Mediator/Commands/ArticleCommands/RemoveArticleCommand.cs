﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands
{
    public class RemoveArticleCommand:IRequest
    {
        public RemoveArticleCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
