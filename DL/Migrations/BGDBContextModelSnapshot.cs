﻿// <auto-generated />
using DL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DL.Migrations
{
    [DbContext(typeof(BGDBContext))]
    partial class BGDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("BingoCardID")
                        .HasColumnType("integer");

                    b.Property<string>("block")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isMarked")
                        .HasColumnType("boolean");

                    b.HasKey("ID");

                    b.HasIndex("BingoCardID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Models.BingoCard", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("GameID")
                        .HasColumnType("integer");

                    b.Property<int>("SeriesID")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("BingoCards");
                });

            modelBuilder.Entity("Models.Game", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GameID"));

                    b.Property<int>("PlayerID")
                        .HasColumnType("integer");

                    b.Property<string>("Question")
                        .HasColumnType("text");

                    b.Property<int>("SeriesID")
                        .HasColumnType("integer");

                    b.Property<bool>("hasWinner")
                        .HasColumnType("boolean");

                    b.HasKey("GameID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Models.IMDb", b =>
                {
                    b.Property<int>("IMDbID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IMDbID"));

                    b.Property<int>("APIID")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("IMDbID");

                    b.ToTable("IMDbs");
                });

            modelBuilder.Entity("Models.Leaderboard", b =>
                {
                    b.Property<int>("LeaderboardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LeaderboardID"));

                    b.Property<int>("PlayerID")
                        .HasColumnType("integer");

                    b.HasKey("LeaderboardID");

                    b.ToTable("Leaderboards");
                });

            modelBuilder.Entity("Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PlayerID"));

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.Property<bool>("isMaster")
                        .HasColumnType("boolean");

                    b.HasKey("PlayerID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Models.Series", b =>
                {
                    b.Property<int>("SeriesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SeriesID"));

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<string>("IMDbID")
                        .HasColumnType("text");

                    b.Property<int>("LeaderboardID")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("SeriesID");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserID"));

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Models.Answer", b =>
                {
                    b.HasOne("Models.BingoCard", null)
                        .WithMany("Answers")
                        .HasForeignKey("BingoCardID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.BingoCard", b =>
                {
                    b.HasOne("Models.User", null)
                        .WithMany("BingoCards")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.BingoCard", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Navigation("BingoCards");
                });
#pragma warning restore 612, 618
        }
    }
}
