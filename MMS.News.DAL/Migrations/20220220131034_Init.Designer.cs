﻿// <auto-generated />


#nullable disable

using System;
using MMS.News.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MMS.News.DAL.Internal;

namespace MMS.News.DAL.Migrations
{
    [DbContext(typeof(NewsContext))]
    [Migration("20220220131034_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0-preview.1.22076.6");

            modelBuilder.Entity("MMS.News.DAL.Entities.AuthorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("MMS.News.DAL.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MMS.News.DAL.Entities.NewsEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("TEXT");

                    b.Property<string>("Headline")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorID");

                    b.HasIndex("CategoryID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("MMS.News.DAL.Entities.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("NewsEntityTagEntity", b =>
                {
                    b.Property<int>("NewsID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsID")
                        .HasColumnType("INTEGER");

                    b.HasKey("NewsID", "TagsID");

                    b.HasIndex("TagsID");

                    b.ToTable("NewsEntityTagEntity");
                });

            modelBuilder.Entity("MMS.News.DAL.Entities.NewsEntity", b =>
                {
                    b.HasOne("MMS.News.DAL.Entities.AuthorEntity", "Author")
                        .WithMany("AuthorsNews")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMS.News.DAL.Entities.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NewsEntityTagEntity", b =>
                {
                    b.HasOne("MMS.News.DAL.Entities.NewsEntity", null)
                        .WithMany()
                        .HasForeignKey("NewsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMS.News.DAL.Entities.TagEntity", null)
                        .WithMany()
                        .HasForeignKey("TagsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MMS.News.DAL.Entities.AuthorEntity", b =>
                {
                    b.Navigation("AuthorsNews");
                });
#pragma warning restore 612, 618
        }
    }
}
