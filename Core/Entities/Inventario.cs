using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Inventario 
{
    [Required]
    public string IdInventario { get; set; }
    [Required]
    public string NombreInventario { get; set; }
    [Required]
    public double Precio { get; set; }
    [Required]
    public int Stock { get; set; }
    [Required]
    public int StockMin { get; set; }
    [Required]
    public int StockMax { get; set; }
    public string CodProductoFk { get; set; }
    public Producto Productos { get; set; }

}
