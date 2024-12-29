﻿// <auto-generated />
using System;
using ApiCursoEntityFrameworkCore.ApplicationDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using NpgsqlTypes;

#nullable disable

namespace ApiCursoEntityFrameworkCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241227182019_TypeMovieTheater")]
    partial class TypeMovieTheater
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "postgis");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiCursoEntityFrameworkCore.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Biografy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("ActorTable");
                });

            modelBuilder.Entity("ApiCursoEntityFrameworkCore.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("InMovie")
                        .HasColumnType("boolean");

                    b.Property<string>("Poster")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime>("PremiereDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("FilmTable");
                });

            modelBuilder.Entity("ApiCursoEntityFrameworkCore.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("GenreTable");
                });

            modelBuilder.Entity("ApiCursoEntityFrameworkCore.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<NpgsqlPoint>("Location")
                        .HasColumnType("point");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("MovieTable");
                });

            modelBuilder.Entity("ApiCursoEntityFrameworkCore.Entities.MovieTheater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasPrecision(9, 2)
                        .HasColumnType("numeric(9,2)");

                    b.Property<int>("TypeMovieTheater")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieTheater");
                });

            modelBuilder.Entity("ApiCursoEntityFrameworkCore.Entities.OfferMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<decimal>("PercentageDiscount")
                        .HasPrecision(5, 2)
                        .HasColumnType("numeric(5,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("OfferMovie");
                });

            modelBuilder.Entity("ApiCursoEntityFrameworkCore.Entities.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PeopleTable");
                });

            modelBuilder.Entity("ApiCursoEntityFrameworkCore.Entities.MovieTheater", b =>
                {
                    b.HasOne("ApiCursoEntityFrameworkCore.Entities.Movie", "Movie")
                        .WithMany("MovieTheaters")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ApiCursoEntityFrameworkCore.Entities.OfferMovie", b =>
                {
                    b.HasOne("ApiCursoEntityFrameworkCore.Entities.Movie", null)
                        .WithOne("OfferMovie")
                        .HasForeignKey("ApiCursoEntityFrameworkCore.Entities.OfferMovie", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiCursoEntityFrameworkCore.Entities.Movie", b =>
                {
                    b.Navigation("MovieTheaters");

                    b.Navigation("OfferMovie");
                });
#pragma warning restore 612, 618
        }
    }
}
