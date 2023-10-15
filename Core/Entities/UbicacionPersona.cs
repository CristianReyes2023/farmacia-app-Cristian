using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class UbicacionPersona : BaseEntity
{
    public string TipoDeVia { get; set; }
    public int NumeroPri { get; set; }
    public char Letra { get; set; }
    public char Bis { get; set; }
    public char LetraSec { get; set; }
    public char Cardinal { get; set; }
    public int NumeroSec { get; set; }
    public char LetraTer { get; set; }
    public int NumeroTer { get; set; }
    public char CardinalSec { get; set; }
    public string Complemento { get; set; }
    public string CodigoPostal { get; set; }
    public string IdPersonaFk { get; set; }
    public Persona Persona { get; set; }
    public int IdCiudadFk { get; set; }
    public Ciudad Ciudad { get; set; }

}
