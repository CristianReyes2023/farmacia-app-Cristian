using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class TipoContacto : BaseEntity
{
    [Required]
    public string NombreTipoContacto { get; set; }
    public ICollection<ContactoPersona> ContactoPersonas { get; set; }
}
