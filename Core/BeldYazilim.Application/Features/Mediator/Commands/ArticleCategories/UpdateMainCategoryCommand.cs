using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCategories
{
    public class UpdateMainCategoryCommand : IRequest
    {
        public int MainCategoryID { get; set; }
        public string UpdatedName { get; set; }
        // Diğer güncellenmesi gereken özellikler
    }

}
