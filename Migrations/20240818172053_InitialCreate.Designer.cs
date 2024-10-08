﻿// <auto-generated />
using CrudBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudBase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240818172053_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrudBase.Models.Client", b =>
                {
                    b.Property<int>("ID_CLIE")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_CLIE"));

                    b.Property<string>("APE_CLIE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APE_CLIE");

                    b.Property<int>("CONTACTO")
                        .HasColumnType("int")
                        .HasColumnName("CONTACTO");

                    b.Property<string>("NOM_CLIE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOM_CLIE");

                    b.HasKey("ID_CLIE");

                    b.ToTable("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}
