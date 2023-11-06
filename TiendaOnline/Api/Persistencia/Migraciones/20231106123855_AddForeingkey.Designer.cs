﻿// <auto-generated />
using System;
using Api.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Persistencia.Migraciones
{
    [DbContext(typeof(AplicacionDbContext))]
    [Migration("20231106123855_AddForeingkey")]
    partial class AddForeingkey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Varios.Carrito", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Carritos");
                });

            modelBuilder.Entity("Varios.Categoria", b =>
                {
                    b.Property<Guid>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            IdCategoria = new Guid("897cf089-90b6-43d1-a5ff-4037970bdbbf"),
                            Descripcion = "Productos electrónicos y gadgets",
                            Nombre = "Electrónica"
                        },
                        new
                        {
                            IdCategoria = new Guid("333cb75d-8444-4325-84c6-e539fdc46f22"),
                            Descripcion = "Ropa de moda para todas las edades",
                            Nombre = "Ropa"
                        },
                        new
                        {
                            IdCategoria = new Guid("35db293b-c55d-43fd-9722-840b02c77d26"),
                            Descripcion = "Productos alimenticios y comestibles",
                            Nombre = "Alimentos"
                        },
                        new
                        {
                            IdCategoria = new Guid("554a879f-204b-42fc-9028-a5835d700582"),
                            Descripcion = "Artículos para el hogar y decoración",
                            Nombre = "Hogar"
                        },
                        new
                        {
                            IdCategoria = new Guid("8e24c6f4-cccb-46aa-b6ca-ffec77a24d82"),
                            Descripcion = "Equipos y accesorios deportivos",
                            Nombre = "Deportes"
                        });
                });

            modelBuilder.Entity("Varios.ItemCarrito", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductoId")
                        .HasColumnType("char(36)");

                    b.Property<double>("Subtotal")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("ItemCarritos");
                });

            modelBuilder.Entity("Varios.Producto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("IdCategoria")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<Guid?>("VendedorId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("VendedorId");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            Id = new Guid("72ca7f60-491e-432b-b18a-4610622b1bb9"),
                            Descripcion = "",
                            Nombre = "Smartphone",
                            Precio = 120.0,
                            Stock = 5
                        },
                        new
                        {
                            Id = new Guid("e6ba5dba-f598-4f50-add8-bb053b7ed581"),
                            Descripcion = "",
                            Nombre = "Laptop",
                            Precio = 150.0,
                            Stock = 5
                        },
                        new
                        {
                            Id = new Guid("89781313-25fd-4546-a22a-c4f217cb8389"),
                            Descripcion = "",
                            Nombre = "Televisor",
                            Precio = 200.0,
                            Stock = 5
                        },
                        new
                        {
                            Id = new Guid("f8a4f4a8-ffa3-477b-ba28-0ad81fce1273"),
                            Descripcion = "",
                            Nombre = "Manzanas",
                            Precio = 2.4900000000000002,
                            Stock = 150
                        },
                        new
                        {
                            Id = new Guid("2bd6c181-9c61-4ca9-aa7b-bb058e3040fc"),
                            Descripcion = "",
                            Nombre = "Pan integral",
                            Precio = 3.9900000000000002,
                            Stock = 200
                        });
                });

            modelBuilder.Entity("Varios.Vendedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Apodo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Vendedor");

                    b.UseTptMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = new Guid("f1430abf-6c04-4e19-bed9-98d030eea630"),
                            Apellido = "Gremory",
                            Apodo = "delfin",
                            Email = "kk@gmail.com",
                            Nombre = "Rias",
                            Password = "dsfsdfv"
                        },
                        new
                        {
                            Id = new Guid("3888a184-8e06-4593-a8d1-086ff578119d"),
                            Apellido = "hyodo",
                            Apodo = "delfin",
                            Email = "ññ@gmail.com",
                            Nombre = "Issei",
                            Password = "30851"
                        });
                });

            modelBuilder.Entity("Varios.Cliente", b =>
                {
                    b.HasBaseType("Varios.Vendedor");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6e4262ca-2163-47b4-b156-57b54f804def"),
                            Apellido = "Perez",
                            Apodo = "juanito123",
                            Email = "juanperez@example.com",
                            Nombre = "Juan",
                            Password = "password123"
                        },
                        new
                        {
                            Id = new Guid("2ca2592d-fd09-4915-9eb7-02d1004ce6e4"),
                            Apellido = "Gomez",
                            Apodo = "anita456",
                            Email = "anagomez@example.com",
                            Nombre = "Ana",
                            Password = "clave456"
                        },
                        new
                        {
                            Id = new Guid("7bd5e208-8d15-463b-a8a0-bc8f7433a599"),
                            Apellido = "Rodriguez",
                            Apodo = "lucho789",
                            Email = "luisr@example.com",
                            Nombre = "Luis",
                            Password = "pass789"
                        },
                        new
                        {
                            Id = new Guid("c848ef91-d1c0-441e-bc6d-ad3db24f60bf"),
                            Apellido = "Martínez",
                            Apodo = "mari123",
                            Email = "mariam@example.com",
                            Nombre = "María",
                            Password = "contraseña123"
                        },
                        new
                        {
                            Id = new Guid("c49c2e1f-48e6-43c8-9f7c-52c8e49e9d6b"),
                            Apellido = "López",
                            Apodo = "carlitos1",
                            Email = "carlosl@example.com",
                            Nombre = "Carlos",
                            Password = "clave1234"
                        });
                });

            modelBuilder.Entity("Varios.Carrito", b =>
                {
                    b.HasOne("Varios.Cliente", "Cliente")
                        .WithMany("Carritos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Varios.ItemCarrito", b =>
                {
                    b.HasOne("Varios.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Varios.Producto", b =>
                {
                    b.HasOne("Varios.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria");

                    b.HasOne("Varios.Vendedor", null)
                        .WithMany("Productos")
                        .HasForeignKey("VendedorId");

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("Varios.Cliente", b =>
                {
                    b.HasOne("Varios.Vendedor", null)
                        .WithOne()
                        .HasForeignKey("Varios.Cliente", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Varios.Vendedor", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Varios.Cliente", b =>
                {
                    b.Navigation("Carritos");
                });
#pragma warning restore 612, 618
        }
    }
}
