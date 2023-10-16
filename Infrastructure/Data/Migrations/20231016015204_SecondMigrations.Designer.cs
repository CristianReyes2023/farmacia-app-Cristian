﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(FarmaciaContext))]
    [Migration("20231016015204_SecondMigrations")]
    partial class SecondMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreCiudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamentoFk");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ContactoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoContactoFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonaFk");

                    b.ToTable("contactopersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreDepartamento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DetalleMovInventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdInventarionFk")
                        .HasColumnType("int");

                    b.Property<int>("IdMovInvFk")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdInventarionFk");

                    b.HasIndex("IdMovInvFk");

                    b.ToTable("detallemovinventario", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FacturaActual")
                        .HasColumnType("int");

                    b.Property<int>("FacturaFinal")
                        .HasColumnType("int");

                    b.Property<int>("FacturaInicial")
                        .HasColumnType("int");

                    b.Property<string>("NroResolucion")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("factura", (string)null);
                });

            modelBuilder.Entity("Core.Entities.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreFormaPago")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("formatopago", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdCodProductoFk")
                        .HasColumnType("int");

                    b.Property<string>("IdInventario")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("IdPresentacionFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreInventario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StockMax")
                        .HasColumnType("int");

                    b.Property<int>("StockMin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCodProductoFk")
                        .IsUnique();

                    b.HasIndex("IdPresentacionFk");

                    b.ToTable("inventario", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreMarca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("marca", (string)null);
                });

            modelBuilder.Entity("Core.Entities.MovimientoInventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaMovimiento")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaVencimiento")
                        .HasColumnType("date");

                    b.Property<int>("IdFacturaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdFormaPagoFk")
                        .HasColumnType("int");

                    b.Property<string>("IdMovimientoInventario")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("IdResponsableFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoMovInvFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdFacturaFk");

                    b.HasIndex("IdFormaPagoFk");

                    b.HasIndex("IdResponsableFk");

                    b.HasIndex("IdTipoMovInvFk");

                    b.ToTable("movimientoinventario", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<string>("IdPersona")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("IdRolPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDocumentoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersonaFk")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdRolPersonaFk");

                    b.HasIndex("IdTipoDocumentoFk");

                    b.HasIndex("IdTipoPersonaFk");

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Presentacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombrePresentacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("presentacion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CodigoProducto")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("IdMarcaFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdMarcaFk");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Core.Entities.RolPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreRolPersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("rolpersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoContacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreTipoContacto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipocontacto", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreTipoDocumento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipodocumento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoMovInventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreTipoMovInventario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipomovinventario", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreTipoPersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipopersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.UbicacionPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bis")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cardinal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CardinalSec")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdCiudadFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<string>("Letra")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LetraSec")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("LetraTer")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("NumeroPri")
                        .HasColumnType("int");

                    b.Property<int>("NumeroSec")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTer")
                        .HasColumnType("int");

                    b.Property<string>("TipoDeVia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudadFk")
                        .IsUnique();

                    b.HasIndex("IdPersonaFk")
                        .IsUnique();

                    b.ToTable("ubicacionpersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.HasOne("Core.Entities.Departamento", "Departamentos")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Core.Entities.ContactoPersona", b =>
                {
                    b.HasOne("Core.Entities.Persona", "Personas")
                        .WithMany("ContactoPersonas")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoContacto", "TipoContactos")
                        .WithMany("ContactoPersonas")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personas");

                    b.Navigation("TipoContactos");
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.HasOne("Core.Entities.Pais", "Paises")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paises");
                });

            modelBuilder.Entity("Core.Entities.DetalleMovInventario", b =>
                {
                    b.HasOne("Core.Entities.Inventario", "Inventarios")
                        .WithMany("DetalleMovInventarios")
                        .HasForeignKey("IdInventarionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.MovimientoInventario", "MovimientoInventarios")
                        .WithMany("DetalleMovInventarios")
                        .HasForeignKey("IdMovInvFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventarios");

                    b.Navigation("MovimientoInventarios");
                });

            modelBuilder.Entity("Core.Entities.Inventario", b =>
                {
                    b.HasOne("Core.Entities.Producto", "Productos")
                        .WithOne("Inventarios")
                        .HasForeignKey("Core.Entities.Inventario", "IdCodProductoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Presentacion", "Presentaciones")
                        .WithMany("Inventarios")
                        .HasForeignKey("IdPresentacionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Presentaciones");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Core.Entities.MovimientoInventario", b =>
                {
                    b.HasOne("Core.Entities.Factura", "Facturas")
                        .WithMany("MovimientoInventarios")
                        .HasForeignKey("IdFacturaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.FormaPago", "FormaPagos")
                        .WithMany("MovimientoInventarios")
                        .HasForeignKey("IdFormaPagoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Persona", "PersonaResponsable")
                        .WithMany("MovimientoInventarios")
                        .HasForeignKey("IdResponsableFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoMovInventario", "TipoMovInventarios")
                        .WithMany("MovimientoInventarios")
                        .HasForeignKey("IdTipoMovInvFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facturas");

                    b.Navigation("FormaPagos");

                    b.Navigation("PersonaResponsable");

                    b.Navigation("TipoMovInventarios");
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.HasOne("Core.Entities.RolPersona", "RolPersonas")
                        .WithMany("Personas")
                        .HasForeignKey("IdRolPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoDocumento", "TipoDocumentos")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoDocumentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoPersona", "TipoPersonas")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RolPersonas");

                    b.Navigation("TipoDocumentos");

                    b.Navigation("TipoPersonas");
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.HasOne("Core.Entities.Marca", "Marcas")
                        .WithMany("Productos")
                        .HasForeignKey("IdMarcaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marcas");
                });

            modelBuilder.Entity("Core.Entities.UbicacionPersona", b =>
                {
                    b.HasOne("Core.Entities.Ciudad", "Ciudades")
                        .WithOne("UbicacionPersona")
                        .HasForeignKey("Core.Entities.UbicacionPersona", "IdCiudadFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Persona", "Personas")
                        .WithOne("UbicacionPersonas")
                        .HasForeignKey("Core.Entities.UbicacionPersona", "IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudades");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.Navigation("UbicacionPersona");
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Core.Entities.Factura", b =>
                {
                    b.Navigation("MovimientoInventarios");
                });

            modelBuilder.Entity("Core.Entities.FormaPago", b =>
                {
                    b.Navigation("MovimientoInventarios");
                });

            modelBuilder.Entity("Core.Entities.Inventario", b =>
                {
                    b.Navigation("DetalleMovInventarios");
                });

            modelBuilder.Entity("Core.Entities.Marca", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Core.Entities.MovimientoInventario", b =>
                {
                    b.Navigation("DetalleMovInventarios");
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.Navigation("ContactoPersonas");

                    b.Navigation("MovimientoInventarios");

                    b.Navigation("UbicacionPersonas");
                });

            modelBuilder.Entity("Core.Entities.Presentacion", b =>
                {
                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Core.Entities.RolPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Core.Entities.TipoContacto", b =>
                {
                    b.Navigation("ContactoPersonas");
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Core.Entities.TipoMovInventario", b =>
                {
                    b.Navigation("MovimientoInventarios");
                });

            modelBuilder.Entity("Core.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
