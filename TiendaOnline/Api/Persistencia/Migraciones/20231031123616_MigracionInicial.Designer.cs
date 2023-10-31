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
    [DbContext(typeof(AplicacionDBContext))]
    [Migration("20231031123616_MigracionInicial")]
    partial class MigracionInicial
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
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
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

                    b.Property<Guid?>("categoriaIdCategoria")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.HasIndex("categoriaIdCategoria");

                    b.ToTable("Producto");
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
                            Id = new Guid("3fc1030c-a230-43a6-adfc-a304eca96c52"),
                            Apellido = "Gremory",
                            Apodo = "delfin",
                            Email = "kk@gmail.com",
                            Nombre = "Rias",
                            Password = "dsfsdfv"
                        },
                        new
                        {
                            Id = new Guid("27cc81f7-3f6f-456e-9ae5-61645466fe52"),
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
                    b.HasOne("Varios.Vendedor", null)
                        .WithMany("Productos")
                        .HasForeignKey("VendedorId");

                    b.HasOne("Varios.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaIdCategoria");

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
