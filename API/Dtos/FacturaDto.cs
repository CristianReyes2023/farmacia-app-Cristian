using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class FacturaDto
{
    public int Id { get; set; }
    public int FacturaInicial { get; set; }
    public int FacturaFinal { get; set; }
    public int FacturaActual { get; set; }
    public string NroResolucion { get; set; }

}
