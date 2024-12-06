﻿// <auto-generated />
using EFCoreManyToMany.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreManyToMany.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20241206064353_added_Users")]
    partial class added_Users
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreManyToMany.Database.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Author1"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Author2"
                        });
                });

            modelBuilder.Entity("EFCoreManyToMany.Database.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            Title = "Book1"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 1,
                            Title = "Book2"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 2,
                            Title = "Book3"
                        });
                });

            modelBuilder.Entity("EFCoreManyToMany.Database.BookCategory", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookCategories");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            BookId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            BookId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            BookId = 3,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("EFCoreManyToMany.Database.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fiction"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Non-Fiction"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Science Fiction"
                        });
                });

            modelBuilder.Entity("EFCoreManyToMany.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EFCoreManyToMany.Database.Book", b =>
                {
                    b.HasOne("EFCoreManyToMany.Database.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("EFCoreManyToMany.Database.BookCategory", b =>
                {
                    b.HasOne("EFCoreManyToMany.Database.Book", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreManyToMany.Database.Category", "Category")
                        .WithMany("BookCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EFCoreManyToMany.Database.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EFCoreManyToMany.Database.Book", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("EFCoreManyToMany.Database.Category", b =>
                {
                    b.Navigation("BookCategories");
                });
#pragma warning restore 612, 618
        }
    }
}