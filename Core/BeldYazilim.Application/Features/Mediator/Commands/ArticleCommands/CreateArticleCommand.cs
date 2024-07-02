using BeldYazilim.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
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
        public int ArticleAuthorID { get; set; }

        public IFormFile Photo { get; set; }

    }
}
