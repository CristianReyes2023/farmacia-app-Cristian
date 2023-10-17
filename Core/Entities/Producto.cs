using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Producto : BaseEntity
{
    [Required]
    public string CodigoProducto { get; set; }
    [Required]
    public string NombreProducto { get; set; }
    public int IdMarcaFk { get; set; }
    public Marca Marcas { get; set; }
    public Inventario Inventarios { get; set; }

}
