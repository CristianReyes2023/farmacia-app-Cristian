using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ContactoPersonaConfiguration : IEntityTypeConfiguration<ContactoPersona>
{
    public void Configure(EntityTypeBuilder<ContactoPersona> builder)
    {
        builder.ToTable("contactopersona");

        builder.HasKey(x=>x.Id);

        builder.HasOne(x=>x.Personas).WithMany(x=>x.ContactoPersonas).HasForeignKey(x=>x.IdPersonaFk);
        builder.HasOne(x=>x.TipoContactos).WithMany(x=>x.ContactoPersonas).HasForeignKey(x=>x.IdTipoContactoFk);
    }
}
