﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vuelos.Data;

namespace Vuelos.Data.Migrations.initial
{
    [DbContext(typeof(EjercicioVuelosContext))]
    [Migration("20220807022010_renameFechaHoraVuelo")]
    partial class renameFechaHoraVuelo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vuelos.Data.Models.Vuelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Demorado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaYHorarioDeLlegada")
                        .HasColumnType("datetime2");

                    b.Property<string>("LineaAerea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDeVuelo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vuelos");
                });
#pragma warning restore 612, 618
        }
    }
}