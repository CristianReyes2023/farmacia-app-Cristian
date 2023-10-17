using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class DetalleMovInventarioConfigurate : IEntityTypeConfiguration<DetalleMovInventario>
{
    public void Configure(EntityTypeBuilder<DetalleMovInventario> builder)
    {
        builder.ToTable("detallemovinventario");

        builder.HasKey(x=>x.Id);

        builder.Property(x=>x.Cantidad).HasColumnType("int");
        builder.Property(x=>x.Precio).HasColumnType("double");

        builder.HasOne(x=>x.Inventarios).WithMany(x=>x.DetalleMovInventarios).HasForeignKey(x=>x.IdInventarionFk);
        builder.HasOne(x=>x.MovimientoInventarios).WithMany(x=>x.DetalleMovInventarios).HasForeignKey(x=>x.IdMovInvFk);
    }
}
