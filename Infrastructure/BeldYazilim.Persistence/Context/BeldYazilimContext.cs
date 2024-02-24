using BeldYazilim.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Persistence.Context
{
    public class BeldYazilimContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<ArticleParentCategory> ArticleParentCategories { get; set; }
        public DbSet<ArticleImage> ArticleImages { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<ArticleAuthor> ArticleAuthors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductSeller> ProductSellers { get; set; }
        public DbSet<ProductShop> ProductShops { get; set; }
        public DbSet<Basket> Baskets{ get; set; }
        public DbSet<BasketItem> BasketItems{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O82KITD;initial Catalog=BeldYazilimDb;integrated Security=true; TrustServerCertificate=True");

        
        }

       
        

    }
}
