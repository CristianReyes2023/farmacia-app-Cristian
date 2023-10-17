using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class TipoMovInventarioConfiguration : IEntityTypeConfiguration<TipoMovInventario>
{
    public void Configure(EntityTypeBuilder<TipoMovInventario> builder)
    {
        builder.ToTable("tipomovinventario");

        builder.HasKey(x=>x.Id);

        builder.Property(x=>x.NombreTipoMovInventario).IsRequired().HasMaxLength(50);
    }
}
