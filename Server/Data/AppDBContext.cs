using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Server.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options):base(options){   }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            //llamo a mi version base
            base.OnModelCreating(modelBuilder);
            Category[] categoriesToSeed = new Category[3];
            for (int i = 1;  i< 4; i++)
            {
                categoriesToSeed[i - 1] = new Category
                {
                    CategoryID = i,
                    ThumbnailImagePath = "uploads/placeholder.jpg",
                    Name = $"Category{i}",
                    Description = $"A description of category{i}"
                };
            }

            modelBuilder.Entity<Category>().HasData(categoriesToSeed);
        }
    }
}
