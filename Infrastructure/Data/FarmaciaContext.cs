using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class FarmaciaContext : DbContext
{
    public FarmaciaContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<ContactoPersona> ContactoPersonas { get; set; }

    public DbSet<Departamento> Departamentos { get; set; }

    public DbSet<DetalleMovInventario> DetalleMovInventarios { get; set; }

    public DbSet<Factura> Facturas { get; set; }

    public DbSet<FormaPago> FormaPagos { get; set; }

    public DbSet<Inventario> Inventarios { get; set; }

    public DbSet<Marca> Marcas { get; set; }

    public DbSet<MovimientoInventario> MovimientoInventarios { get; set; }

    public DbSet<Pais> Paises { get; set; }

    public DbSet<Persona> Personas { get; set; }

    public DbSet<Presentacion> Presentaciones { get; set; }

    public DbSet<Producto> Productos { get; set; }

    public DbSet<RolPersona> RolPersonas { get; set; }
    public DbSet<TipoContacto> TipoContactos { get; set; }
    public DbSet<TipoDocumento> TipoDocumentos { get; set; }
    public DbSet<TipoMovInventario> TipoMovInventarios { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set; }
    public DbSet<UbicacionPersona> UbicacionPersonas { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories{ get; set; }
    public DbSet<BookCategory> BookCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}