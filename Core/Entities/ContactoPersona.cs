using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class ContactoPersona : BaseEntity
{
    public string IdPersonaFk { get; set; }
    public Persona Persona { get; set; }
    public int IdTipoContactoFk { get; set; }
    public TipoContacto TipoContactos { get; set; }

}
