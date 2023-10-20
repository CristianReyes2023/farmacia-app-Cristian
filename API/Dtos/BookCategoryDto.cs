using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class BookCategoryDto
{
    public string Nota { get; set; }
    public int IdBookFk { get; set; }

    public int IdCategoryFk { get; set; }
}
