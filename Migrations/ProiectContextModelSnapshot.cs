﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect.Data;

#nullable disable

namespace Proiect.Migrations
{
    [DbContext(typeof(ProiectContext))]
    partial class ProiectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect.Models.Angajat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Data_Angajare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Angajat");
                });

            modelBuilder.Entity("Proiect.Models.Partener", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Partener");
                });

            modelBuilder.Entity("Proiect.Models.Produs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Cantitate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_Exp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartenerID")
                        .HasColumnType("int");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("PartenerID");

                    b.ToTable("Produse");
                });

            modelBuilder.Entity("Proiect.Models.Transport", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("AngajatID")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartenerID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AngajatID");

                    b.HasIndex("PartenerID");

                    b.ToTable("Transport");
                });

            modelBuilder.Entity("Proiect.Models.Produs", b =>
                {
                    b.HasOne("Proiect.Models.Partener", "Partener")
                        .WithMany("Produse")
                        .HasForeignKey("PartenerID");

                    b.Navigation("Partener");
                });

            modelBuilder.Entity("Proiect.Models.Transport", b =>
                {
                    b.HasOne("Proiect.Models.Angajat", "Angajat")
                        .WithMany("Transporturi")
                        .HasForeignKey("AngajatID");

                    b.HasOne("Proiect.Models.Partener", "Partener")
                        .WithMany("Transporturi")
                        .HasForeignKey("PartenerID");

                    b.Navigation("Angajat");

                    b.Navigation("Partener");
                });

            modelBuilder.Entity("Proiect.Models.Angajat", b =>
                {
                    b.Navigation("Transporturi");
                });

            modelBuilder.Entity("Proiect.Models.Partener", b =>
                {
                    b.Navigation("Produse");

                    b.Navigation("Transporturi");
                });
#pragma warning restore 612, 618
        }
    }
}
