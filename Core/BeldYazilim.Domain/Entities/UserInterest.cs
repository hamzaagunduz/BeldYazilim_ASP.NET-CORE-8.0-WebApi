using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class UserInterest
    {
        public int UserInterestID { get; set; }
        public string UserInterestName { get; set;}
        public string UserInterestImageUrl { get; set;}
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

    }
}
