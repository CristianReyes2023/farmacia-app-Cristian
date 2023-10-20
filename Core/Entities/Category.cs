using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Category : BaseEntity
{
    public string CategoryName { get; set; }
    public ICollection<BookCategory> BookCategories { get; set; }
}
