using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Models
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) :base(options)
        {

        }

        /// <summary>
        /// 2 cách thiết lập quan hệ
        /// 1 là sử dụng Annotation
        /// 2 là config ở trong Dbcontext
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewsDb;Integrated Security=True");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasKey(e => e.ID);

            //modelBuilder.Entity<BlogPost>()
            //    .Property(e => e.PostID).UseSqlServerIdentityColumn();
            //ID tự động tăng
            modelBuilder.Entity<Post>(b =>
            {
                b.HasKey(e => e.ID);
                b.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Category>()
                .HasKey(e => e.ID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Posts)
                .WithOne(e => e.Category);

            modelBuilder.Entity<Post>()
                .Property(e => e.ViewCount)
                .HasDefaultValue(0);

            //data seeding
            modelBuilder.Entity<Category>()
                .HasData(new Category { ID = 1, CategoryName = "Thể thao" });
            modelBuilder.Entity<Category>()
               .HasData(new Category { ID = 2, CategoryName = "Công Nghệ" });
            modelBuilder.Entity<Post>()
                .HasData(new Post
                {
                    ID = 1,
                    CateID = 1,
                    AvatarImage = "https://znews-photo.zadn.vn/w1024/Uploaded/tmuitg/2019_07_25/16_1.jpg",
                    PostTitle = "Quang Hải lập công abc xyz",
                    PostContent = "abc xyz",
                    ViewCount = 0,
                });
               
            
        }
    }
}
