using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class InventarioDto
{
    public string Id { get; set; }
    public string NombreInventario { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
    public string IdCodProductoFk { get; set; }
    public int IdPresentacionFk { get; set; }
}
