using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infrastructure.Data.Configuration;
public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("inventario");

        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.IdInventario).IsRequired().HasMaxLength(10);
        builder.Property(x=>x.NombreInventario).IsRequired().HasMaxLength(50);

        builder.Property(x=>x.Precio).HasColumnType("double");
        builder.Property(x=>x.Stock).HasColumnType("int");
        builder.Property(x=>x.StockMin).HasColumnType("int");
        builder.Property(x=>x.StockMax).HasColumnType("int");

        builder.HasOne(x=>x.Productos).WithOne(x=>x.Inventarios).HasForeignKey<Inventario>(x=>x.CodProductoFk);
        builder.HasOne(x=>x.Presentaciones).WithMany(x=>x.Inventarios).HasForeignKey(x=>x.IdPresentacionFk);
    }
}
