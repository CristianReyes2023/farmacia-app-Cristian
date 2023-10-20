using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class BookCategory
{
    public string Nota { get; set; }
    public int IdBookFk { get; set; }
    public Book Book { get; set; }
    public int IdCategoryFk { get; set; }
    public Category Category { get; set; }
}
