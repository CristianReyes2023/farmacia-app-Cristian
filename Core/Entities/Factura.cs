using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Factura : BaseEntity
{
    [Required]
    public int FacturaInicial { get; set; }
    [Required]
    public int FacturaFinal { get; set; }
    [Required]
    public int FacturaActual { get; set; }
    public string NroResolucion { get; set; }
    public ICollection<MovimientoInventario> MovimientoInventarios { get; set; }
    
}
