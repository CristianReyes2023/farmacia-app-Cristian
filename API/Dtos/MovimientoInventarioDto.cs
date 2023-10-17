using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class MovimientoInventarioDto
{
    public string Id { get; set; }
    public DateOnly FechaMovimiento { get; set; }
    public DateOnly FechaVencimiento { get; set; }
    public int IdFormaPagoFk { get; set; }
    public string IdResponsableFk { get; set; }
    public int IdTipoMovInvFk { get; set; }
    public int IdFacturaFk { get; set; }
}
