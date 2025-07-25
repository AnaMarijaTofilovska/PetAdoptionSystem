﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PetAdoptionSystem.Data;

#nullable disable

namespace PetAdoptionSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250621161552_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PetAdoptionSystem.Models.Adopter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Adopters");
                });

            modelBuilder.Entity("PetAdoptionSystem.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdopterId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("AdoptionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<bool>("IsAdopted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AdopterId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetAdoptionSystem.Models.Pet", b =>
                {
                    b.HasOne("PetAdoptionSystem.Models.Adopter", "Adopter")
                        .WithMany("AdoptedPets")
                        .HasForeignKey("AdopterId");

                    b.Navigation("Adopter");
                });

            modelBuilder.Entity("PetAdoptionSystem.Models.Adopter", b =>
                {
                    b.Navigation("AdoptedPets");
                });
#pragma warning restore 612, 618
        }
    }
}
