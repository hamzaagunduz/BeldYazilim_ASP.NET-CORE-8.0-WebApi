using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Dto.AppUserDtos
{
    public class UpdateAppUserDtos
    {

            public int appUserID { get; set; }
            public string firstName { get; set; }
            public string surname { get; set; }
            public int roleId { get; set; }
            public string? district { get; set; }
            public string? about { get; set; }
            public string? imageUrl { get; set; }
            public IFormFile Photo { get; set; }


            //public string password { get; set; }
            public string? city { get; set; }
            //public int confirmCode { get; set; }




    }
}
