using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
{
    public void Configure(EntityTypeBuilder<BookCategory> builder)
    {
        builder.ToTable("bookcategory");
        
        builder.HasKey(x=> new {x.IdBookFk,x.IdCategoryFk});

        builder.HasOne(x=>x.Book).WithMany(x=>x.BookCategories).HasForeignKey(x=>x.IdBookFk);
        builder.HasOne(x=>x.Category).WithMany(x=>x.BookCategories).HasForeignKey(x=>x.IdCategoryFk);
        
    }
}
