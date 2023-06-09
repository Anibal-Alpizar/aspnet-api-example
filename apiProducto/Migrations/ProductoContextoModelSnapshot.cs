﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiProducto.Data;

#nullable disable

namespace apiProducto.Migrations
{
    [DbContext(typeof(ProductoContexto))]
    partial class ProductoContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("apiProducto.Models.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProducto"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Garantia")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("idProducto");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            idProducto = 1,
                            Cantidad = 14,
                            Descripcion = "Arduino",
                            Garantia = false,
                            Precio = 15000m
                        },
                        new
                        {
                            idProducto = 2,
                            Cantidad = 5,
                            Descripcion = "Impresora 3D",
                            Garantia = true,
                            Precio = 458999.8m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
