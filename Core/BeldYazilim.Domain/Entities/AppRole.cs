using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public const string Admin = "Admin";
        public const string Author = "Author";
        public const string Designer = "Designer";
    }
}
