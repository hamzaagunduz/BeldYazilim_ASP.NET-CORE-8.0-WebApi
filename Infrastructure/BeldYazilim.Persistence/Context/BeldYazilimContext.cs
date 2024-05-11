using BeldYazilim.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BeldYazilim.Persistence.Context
{
    public class BeldYazilimContext: IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O82KITD;initial Catalog=BeldYazilimDb;integrated Security=true; TrustServerCertificate=True");


        }
        public DbSet<ArticleMainCategory> ArticleMainCategory { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleAuthor> ArticleAuthors { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<ArticleImage> ArticleImages { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }

        public DbSet<ProductSeller> ProductSellers { get; set; }

        public DbSet<ProductShop> ProductShops { get; set; }
        public DbSet<FooterAbout> FooterAbouts { get; set; }


        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Feature> Features { get; set; }

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<ProductCategoryLink> ProductCategoryLinks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Article>()
                .HasOne(a => a.ArticleAuthor)
                .WithMany(aa => aa.Articles)
                .HasForeignKey(a => a.ArticleAuthorID)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<AppUser>()
                .HasOne(u => u.ArticleAuthor)
                .WithOne(aa => aa.AppUser)
                .HasForeignKey<ArticleAuthor>(aa => aa.AppUserID);

            modelBuilder.Entity<BasketItem>()
                .HasOne(bi => bi.Product)
                .WithMany(p => p.BasketItems)
                .HasForeignKey(bi => bi.ProductID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ArticleTag>()
    .HasKey(at => new { at.ArticleID, at.TagID });


        }





    }
}
