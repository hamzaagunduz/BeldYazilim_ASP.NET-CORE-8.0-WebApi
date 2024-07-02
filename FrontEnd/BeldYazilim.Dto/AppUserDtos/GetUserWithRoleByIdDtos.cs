using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Dto.AppUserDtos
{
    public class GetUserWithRoleByIdDtos
    {
            public int id { get; set; }
            public string firstName { get; set; }
            public string surname { get; set; }
            public string email { get; set; }
            public string about { get; set; }
            public DateTime registrationDate { get; set; }
            public string imageUrl { get; set; }
            public string role { get; set; }


    }
}
