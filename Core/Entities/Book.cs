using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Book : BaseEntity
{
    public string Title { get; set;}
    public ICollection<BookCategory> BookCategories { get; set; }
}   
