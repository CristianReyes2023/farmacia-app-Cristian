using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class MovimientoInventario : BaseEntity
{
    [Required]
    public string IdMovimientoInventario { get; set; }
    [Required]
    public DateOnly FechaMovimiento { get; set; }
    [Required]
    public DateOnly FechaVencimiento { get; set; }
    [Required]
    public int IdFormaPagoFk { get; set; }
    public FormaPago FormaPagos { get; set; }
    public string IdResponsableFk { get; set; }
    public Persona PersonaResponsable { get; set; }
    public string IdReceptor { get; set; }
    public Persona PersonaReceptor { get; set; }
    public int IdTipoMovInvFk { get; set; }
    public TipoMovInventario TipoMovInventarios { get; set; }
    public ICollection<DetalleMovInventario> DetalleMovInventarios { get; set; }
}
