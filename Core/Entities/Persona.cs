using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Persona : BaseEntity
{
    [Required]
    public string IdPersona {get;set;}
    [Required]
    public string NombrePersona { get; set; }
    [Required]
    public DateOnly FechaRegistro { get; set; }
    [Required]
    public int IdTipoDocumentoFk { get; set; }
    public TipoDocumento TipoDocumentos { get; set; }
    public int IdRolPersonaFk { get; set; }
    public RolPersona RolPersonas { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public TipoPersona TipoPersonas { get; set; }
    public UbicacionPersona UbicacionPersonas { get; set; }
    public ICollection<ContactoPersona> ContactoPersonas { get; set; }
    public ICollection<MovimientoInventario> MovimientoInventarios { get; set; }
}
