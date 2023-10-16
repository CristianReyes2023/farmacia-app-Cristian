using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class DetalleMovInventarioDto
{
    public int Id { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public int IdInventarionFk { get; set; }
    public int IdMovInvFk { get; set; }
}
