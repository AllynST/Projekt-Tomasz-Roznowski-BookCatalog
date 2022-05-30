﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt_Tomasz_Roznowski_BookCatalog.Data;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Migrations
{
    [DbContext(typeof(CatalogContext))]
    partial class CatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.Author", b =>
                {
                    b.Property<int>("Author_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Author_ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.Book", b =>
                {
                    b.Property<int>("Book_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Author_ID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Format")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Genre_ID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("User_ID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("User_ID1")
                        .HasColumnType("INTEGER");

                    b.HasKey("Book_ID");

                    b.HasIndex("Author_ID");

                    b.HasIndex("Genre_ID");

                    b.HasIndex("User_ID");

                    b.HasIndex("User_ID1");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.Genre", b =>
                {
                    b.Property<int>("Genre_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Genre_ID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.Review", b =>
                {
                    b.Property<int>("Review_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AddedByUser_ID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Book_ID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Review_ID");

                    b.HasIndex("AddedByUser_ID");

                    b.HasIndex("Book_ID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.User", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("User_ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.Book", b =>
                {
                    b.HasOne("Projekt_Tomasz_Roznowski_BookCatalog.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("Author_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekt_Tomasz_Roznowski_BookCatalog.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("Genre_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekt_Tomasz_Roznowski_BookCatalog.Models.User", null)
                        .WithMany("FinishedBooks")
                        .HasForeignKey("User_ID");

                    b.HasOne("Projekt_Tomasz_Roznowski_BookCatalog.Models.User", null)
                        .WithMany("ReadList")
                        .HasForeignKey("User_ID1");

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.Review", b =>
                {
                    b.HasOne("Projekt_Tomasz_Roznowski_BookCatalog.Models.User", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedByUser_ID");

                    b.HasOne("Projekt_Tomasz_Roznowski_BookCatalog.Models.Book", null)
                        .WithMany("Reviews")
                        .HasForeignKey("Book_ID");

                    b.Navigation("AddedBy");
                });

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.Book", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Projekt_Tomasz_Roznowski_BookCatalog.Models.User", b =>
                {
                    b.Navigation("FinishedBooks");

                    b.Navigation("ReadList");
                });
#pragma warning restore 612, 618
        }
    }
}
