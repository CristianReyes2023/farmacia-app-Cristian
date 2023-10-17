using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class FormatoPagoConfigurate : IEntityTypeConfiguration<FormaPago>
{
    public void Configure(EntityTypeBuilder<FormaPago> builder)
    {
        builder.ToTable("formatopago");

        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.NombreFormaPago).IsRequired().HasMaxLength(50);
    }
}
