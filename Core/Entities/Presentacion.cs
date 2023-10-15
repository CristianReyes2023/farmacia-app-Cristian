using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Presentacion : BaseEntity
{
    [Required]
    public string NombrePresentacion { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }
    
}