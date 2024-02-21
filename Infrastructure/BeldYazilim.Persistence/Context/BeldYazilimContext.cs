using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Persistence.Context
{
    public class BeldYazilimContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O82KITD;initial Catalog=BeldYazilimDb;integrated Security=true; TrustServerCertificate=True");

        }
    }
}
