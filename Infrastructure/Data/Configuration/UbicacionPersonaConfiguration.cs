using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class UbicacionPersonaConfiguration : IEntityTypeConfiguration<UbicacionPersona>
{
    public void Configure(EntityTypeBuilder<UbicacionPersona> builder)
    {
        builder.ToTable("ubicacionpersona");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.TipoDeVia).IsRequired().HasMaxLength(50);
        builder.Property(x => x.NumeroPri).HasColumnType("int");
        builder.Property(x => x.Letra).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Bis).IsRequired().HasMaxLength(10);
        builder.Property(x => x.LetraSec).IsRequired().HasMaxLength(10);
        builder.Property(x => x.Cardinal).IsRequired().HasMaxLength(10);
        builder.Property(x => x.NumeroSec).HasColumnType("int");
        builder.Property(x => x.LetraTer).IsRequired().HasMaxLength(10);
        builder.Property(x => x.NumeroTer).HasColumnType("int");
        builder.Property(x => x.CardinalSec).IsRequired().HasMaxLength(10);
        builder.Property(x => x.Complemento).IsRequired().HasMaxLength(50);
        builder.Property(x => x.CodigoPostal).IsRequired().HasMaxLength(10);
        builder.HasOne(x => x.Ciudades).WithOne(x => x.UbicacionPersona).HasForeignKey<UbicacionPersona>(x => x.IdCiudadFk);
        builder.HasOne(x => x.Personas).WithOne(x => x.UbicacionPersonas).HasForeignKey<UbicacionPersona>(x => x.IdPersonaFk);

    }
}
