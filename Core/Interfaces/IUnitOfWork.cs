using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces;
public interface IUnitOfWork 
{
    ICiudad Ciudades {get;}
    IContactoPersona ContactoPersonas {get;}
    IDepartamento Departamentos {get;}
    IDetalleMovInventario DetalleMovInventarios {get;}
    IFactura Facturas {get;}
    IFormaPago FormaPagos {get;}
    IInventario Inventarios {get;}
    IMarca Marcas {get;}
    IMovimientoInventario MovimientoInventarios {get;}
    IPais Paises {get;}
    IPersona Personas {get;}
    IPresentacion Presentaciones {get;}
    IProducto Productos {get;}
    IRolPersona RolPersonas {get;}
    ITipoContacto TipoContactos {get;}
    ITipoDocumento TipoDocumentos {get;}
    ITipoMovInventario TipoMovInventarios {get;}
    ITipoPersona TipoPersonas {get;}
    IUbicacionPersona UbicacionPersonas {get;}

    Task<int> SaveAsync();
}
