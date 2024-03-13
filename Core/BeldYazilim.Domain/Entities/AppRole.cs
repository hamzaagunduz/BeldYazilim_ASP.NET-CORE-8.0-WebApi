using BeldYazilim.Application.Enums;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        public static string GetRoleName(RolesType roleType)
        {
            switch (roleType)
            {
                case RolesType.Admin:
                    return Admin;
                case RolesType.Author:
                    return Author;
                case RolesType.Designer:
                    return Designer;
                default:
                    throw new ArgumentOutOfRangeException(nameof(roleType), roleType, null);

            }
        }
    }
}