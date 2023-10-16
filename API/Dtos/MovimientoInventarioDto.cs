using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class MovimientoInventarioDto
{
    public int Id { get; set; }
    public string IdMovimientoInventario { get; set; }
    public DateOnly FechaMovimiento { get; set; }
    public DateOnly FechaVencimiento { get; set; }
    public int IdFormaPagoFk { get; set; }
    public int IdResponsableFk { get; set; }
    public int IdTipoMovInvFk { get; set; }
    public int IdFacturaFk { get; set; }
}
