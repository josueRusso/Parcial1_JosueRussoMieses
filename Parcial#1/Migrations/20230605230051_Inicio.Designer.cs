﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial_1.Context;

#nullable disable

namespace Parcial_1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230605230051_Inicio")]
    partial class Inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Parcial_1.Model.Ingresos", b =>
                {
                    b.Property<int>("IngresoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Monto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IngresoId");

                    b.ToTable("Ingresos");
                });
#pragma warning restore 612, 618
        }
    }
}
