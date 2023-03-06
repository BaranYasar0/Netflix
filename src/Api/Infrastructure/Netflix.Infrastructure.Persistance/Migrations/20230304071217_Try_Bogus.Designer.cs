﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Netflix.Infrastructure.Persistance.Contexts;

#nullable disable

namespace Netflix.Infrastructure.Persistance.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20230304071217_Try_Bogus")]
    partial class Try_Bogus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryMovie", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CategoryMovie");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("C_Name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time")
                        .HasColumnName("MovieLength");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MovieName");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.MovieComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Content");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("MovieId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_Id");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("MovieComment");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.MovieCommentVote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieCommentId")
                        .HasColumnType("int")
                        .HasColumnName("MovieCommentId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_Id");

                    b.Property<int>("VoteType")
                        .HasColumnType("int")
                        .HasColumnName("VoteType");

                    b.HasKey("Id");

                    b.HasIndex("MovieCommentId");

                    b.HasIndex("UserId");

                    b.ToTable("MovieCommentVote");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.MovieFavourite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("MovieId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_Id");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("MovieFavourite");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.MovieVote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("MovieId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_Id");

                    b.Property<int>("VoteType")
                        .HasColumnType("int")
                        .HasColumnName("VoteType");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("MovieVote");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("E-ContactNumber");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("E-mail");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("E-FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("E-LastName");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactNumber = "+90-702-210-4-186",
                            CreatedDate = new DateTime(2022, 11, 28, 8, 6, 22, 436, DateTimeKind.Local).AddTicks(242),
                            Email = "Barkan_Avan@yahoo.com",
                            FirstName = "Amelya",
                            LastName = "Arıcan"
                        },
                        new
                        {
                            Id = 2,
                            ContactNumber = "+90-440-015-65-75",
                            CreatedDate = new DateTime(2023, 2, 21, 12, 36, 49, 821, DateTimeKind.Local).AddTicks(5682),
                            Email = "Bukak0@yahoo.com",
                            FirstName = "Okan",
                            LastName = "Yıldırım "
                        },
                        new
                        {
                            Id = 3,
                            ContactNumber = "+90-227-944-24-78",
                            CreatedDate = new DateTime(2022, 11, 30, 0, 33, 6, 370, DateTimeKind.Local).AddTicks(1887),
                            Email = "Akkun88@gmail.com",
                            FirstName = "Gazanfer",
                            LastName = "Bademci"
                        },
                        new
                        {
                            Id = 4,
                            ContactNumber = "+90-182-015-2-303",
                            CreatedDate = new DateTime(2023, 1, 19, 21, 44, 3, 495, DateTimeKind.Local).AddTicks(7334),
                            Email = "Bugduz_Kuzucu@hotmail.com",
                            FirstName = "Hayat",
                            LastName = "Kuzucu"
                        },
                        new
                        {
                            Id = 5,
                            ContactNumber = "+90-275-546-3-635",
                            CreatedDate = new DateTime(2023, 2, 21, 4, 18, 8, 271, DateTimeKind.Local).AddTicks(4571),
                            Email = "Isig27@gmail.com",
                            FirstName = "Aykut",
                            LastName = "Demirel"
                        },
                        new
                        {
                            Id = 6,
                            ContactNumber = "+90-268-485-3-013",
                            CreatedDate = new DateTime(2022, 12, 17, 21, 49, 38, 717, DateTimeKind.Local).AddTicks(9046),
                            Email = "Cilenti49@yahoo.com",
                            FirstName = "Barış",
                            LastName = "Denkel"
                        },
                        new
                        {
                            Id = 7,
                            ContactNumber = "+90-773-373-9-468",
                            CreatedDate = new DateTime(2023, 1, 12, 17, 45, 35, 896, DateTimeKind.Local).AddTicks(4638),
                            Email = "Arpat21@hotmail.com",
                            FirstName = "Gaffar",
                            LastName = "Alyanak"
                        },
                        new
                        {
                            Id = 8,
                            ContactNumber = "+90-777-999-5-191",
                            CreatedDate = new DateTime(2022, 12, 23, 10, 5, 53, 138, DateTimeKind.Local).AddTicks(430),
                            Email = "Adaldi.Cetin12@gmail.com",
                            FirstName = "Hazan",
                            LastName = "Koç"
                        },
                        new
                        {
                            Id = 9,
                            ContactNumber = "+90-773-019-73-39",
                            CreatedDate = new DateTime(2023, 2, 13, 3, 36, 45, 368, DateTimeKind.Local).AddTicks(2560),
                            Email = "Alpilig_Daglaroglu@gmail.com",
                            FirstName = "Demirhan",
                            LastName = "Nebioğlu"
                        },
                        new
                        {
                            Id = 10,
                            ContactNumber = "+90-682-807-4-838",
                            CreatedDate = new DateTime(2022, 11, 28, 2, 57, 50, 670, DateTimeKind.Local).AddTicks(968),
                            Email = "Bastugrul.Yalcin26@yahoo.com",
                            FirstName = "Selen",
                            LastName = "Tokgöz"
                        });
                });

            modelBuilder.Entity("CategoryMovie", b =>
                {
                    b.HasOne("Netflix.Api.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Netflix.Api.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.MovieComment", b =>
                {
                    b.HasOne("Netflix.Api.Domain.Entities.Movie", "Movie")
                        .WithMany("MovieComments")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Netflix.Api.Domain.Entities.User", "User")
                        .WithMany("MovieComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.MovieCommentVote", b =>
                {
                    b.HasOne("Netflix.Api.Domain.Entities.MovieComment", "MovieComment")
                        .WithMany("MovieCommentVotes")
                        .HasForeignKey("MovieCommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Netflix.Api.Domain.Entities.User", "User")
                        .WithMany("MovieCommentVotes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MovieComment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.MovieFavourite", b =>
                {
                    b.HasOne("Netflix.Api.Domain.Entities.Movie", "Movie")
                        .WithMany("MovieFavourites")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Netflix.Api.Domain.Entities.User", "User")
                        .WithMany("MovieFavourites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.MovieVote", b =>
                {
                    b.HasOne("Netflix.Api.Domain.Entities.Movie", "Movie")
                        .WithMany("MovieVotes")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Netflix.Api.Domain.Entities.User", "User")
                        .WithMany("MovieVotes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.Movie", b =>
                {
                    b.Navigation("MovieComments");

                    b.Navigation("MovieFavourites");

                    b.Navigation("MovieVotes");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.MovieComment", b =>
                {
                    b.Navigation("MovieCommentVotes");
                });

            modelBuilder.Entity("Netflix.Api.Domain.Entities.User", b =>
                {
                    b.Navigation("MovieCommentVotes");

                    b.Navigation("MovieComments");

                    b.Navigation("MovieFavourites");

                    b.Navigation("MovieVotes");
                });
#pragma warning restore 612, 618
        }
    }
}
