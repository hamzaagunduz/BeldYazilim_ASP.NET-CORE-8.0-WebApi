using BeldYazilim.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace BeldYazilim.Persistence.Context
{
    public class BeldYazilimContext:DbContext/*IdentityDbContext<AppUser,AppRole,int>*/
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O82KITD;initial Catalog=BeldYazilimDb;integrated Security=true; TrustServerCertificate=True");


        }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleAuthor> ArticleAuthors { get; set; }
        public DbSet<ArticleCategoryLink> ArticleCategoryLinks { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<ArticleImage> ArticleImages { get; set; }

        public DbSet<ProductSeller> ProductSellers { get; set; }

        public DbSet<ProductShop> ProductShops { get; set; }


        //public DbSet<Product> Products { get; set; }
        //public DbSet<ProductCategory> ProductCategories { get; set; }
        //public DbSet<ProductImage> ProductImages { get; set; }

        //public DbSet<Basket> Baskets { get; set; }
        //public DbSet<BasketItem> BasketItems { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ArticleCategoryLink>()
                .HasKey(acl => acl.ArticleCategoryLinkID);

            modelBuilder.Entity<ArticleCategoryLink>()
                .HasOne(acl => acl.Article)
                .WithMany(a => a.ArticleCategoryLinks)
                .HasForeignKey(acl => acl.ArticleID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ArticleCategoryLink>()
                .HasOne(acl => acl.MainCategory)
                .WithMany(mc => mc.ArticleCategoryLinks)
                .HasForeignKey(acl => acl.MainCategoryID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ArticleCategoryLink>()
                .HasOne(acl => acl.Subcategory)
                .WithMany(sc => sc.ArticleCategoryLinks)
                .HasForeignKey(acl => acl.SubcategoryID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Article>()
                .HasOne(a => a.ArticleAuthor)
                .WithMany(aa => aa.Articles)
                .HasForeignKey(a => a.ArticleAuthorID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AppUser>()
                .HasOne(u => u.ArticleAuthor)
                .WithOne(aa => aa.AppUser)
                .HasForeignKey<ArticleAuthor>(aa => aa.AppUserID);





        }





    }
}
