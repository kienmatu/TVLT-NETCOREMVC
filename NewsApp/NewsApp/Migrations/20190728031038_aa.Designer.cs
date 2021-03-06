﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsApp.Models;

namespace NewsApp.Migrations
{
    [DbContext(typeof(NewsContext))]
    [Migration("20190728031038_aa")]
    partial class aa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsApp.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Thể thao"
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Công Nghệ"
                        });
                });

            modelBuilder.Entity("NewsApp.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarImage")
                        .IsRequired();

                    b.Property<int>("CateID");

                    b.Property<string>("PostContent")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("PostTeaser")
                        .HasMaxLength(400);

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("ViewCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.HasKey("ID");

                    b.HasIndex("CateID");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AvatarImage = "https://znews-photo.zadn.vn/w1024/Uploaded/tmuitg/2019_07_25/16_1.jpg",
                            CateID = 1,
                            PostContent = "abc xyz",
                            PostTitle = "Quang Hải lập công abc xyz",
                            ViewCount = 0
                        });
                });

            modelBuilder.Entity("NewsApp.Models.Post", b =>
                {
                    b.HasOne("NewsApp.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CateID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
