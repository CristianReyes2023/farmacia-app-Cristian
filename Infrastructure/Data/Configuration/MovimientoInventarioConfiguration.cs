using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class MovimientoInventarioConfiguration : IEntityTypeConfiguration<MovimientoInventario>
{
    public void Configure(EntityTypeBuilder<MovimientoInventario> builder)
    {
        builder.ToTable("movimientoinventario");

        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.IdMovimientoInventario).IsRequired().HasMaxLength(10);

        builder.Property(x=>x.FechaMovimiento).HasColumnType("date");
        builder.Property(x=>x.FechaVencimiento).HasColumnType("date");

        builder.HasOne(x=>x.FormaPagos).WithMany(x=>x.MovimientoInventarios).HasForeignKey(x=>x.IdFormaPagoFk);
        builder.HasOne(x=>x.PersonaResponsable).WithMany(x=>x.MovimientoInventarios).HasForeignKey(x=>x.IdResponsableFk);
        builder.HasOne(x=>x.PersonaReceptor).WithMany(x=>x.MovimientoInventarios).HasForeignKey(x=>x.IdReceptor);
        builder.HasOne(x=>x.TipoMovInventarios).WithMany(x=>x.MovimientoInventarios).HasForeignKey(x=>x.IdTipoMovInvFk);
    }
}
