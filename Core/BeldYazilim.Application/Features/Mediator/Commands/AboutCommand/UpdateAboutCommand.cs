using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.AboutCommand
{
    public class UpdateAboutCommand:IRequest
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Title2 { get; set; }
        public string Content2 { get; set; }
        public IFormFile Photo { get; set; }
        public IFormFile Photo2 { get; set; }

    }
}
