using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class RolPersona : BaseEntity
{
    [Required]
    public string NombreRolPersona { get; set; }
    public ICollection<Persona> Personas { get; set; }
}
