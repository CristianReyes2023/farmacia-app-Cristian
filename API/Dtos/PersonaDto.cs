using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class PersonaDto
{
    public int Id { get; set; }
    public string IdPersona { get; set; }
    public string NombrePersona { get; set; }
    public DateOnly FechaRegistro { get; set; }
    public int IdTipoDocumentoFk { get; set; }
    public int IdRolPersonaFk { get; set; }
    public int IdTipoPersonaFk { get; set; }
}
