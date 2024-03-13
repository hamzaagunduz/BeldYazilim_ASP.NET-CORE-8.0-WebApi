using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class AppUser: IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; } 
        public string? District { get; set; }
        public string? About { get; set; }      
        public DateTime RegistrationDate { get; set; }
        public string? City { get; set; }
        public string? ImageUrl { get; set; }
        public int ConfirmCode { get; set; }
        public ArticleAuthor ArticleAuthor { get; set; }

        public List<ArticleComment> Comments { get; set; }

        public ProductSeller ProductSeller { get; set; }

        public Basket Basket { get; set; }




    }
}
