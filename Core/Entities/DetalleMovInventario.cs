using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class DetalleMovInventario : BaseEntity
{
    [Required]
    public int Cantidad { get; set; }
    [Required]
    public double Precio { get; set; }
    [Required]
    public string IdInvetarion { get; set; }
    public Inventario Inventarios { get; set; }
    public string IdMovInvFk { get; set; }
    public MovimientoInventario MovimientoInventarios { get; set; }
}
