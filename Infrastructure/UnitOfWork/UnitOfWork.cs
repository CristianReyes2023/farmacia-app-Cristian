using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{

    private ICiudad _ciudades;
    private IContactoPersona _contactopersonas;
    private IDepartamento _departamentos;
    private IDetalleMovInventario _detallemovinvetarios;
    private IFactura _facturas;
    private IFormaPago _formatopagos;
    private IInventario _inventarios;
    private IMarca _marcas;
    private IMovimientoInventario _movimientoinventarios;
    private IPais _paises;
    private IPersona _personas;
    private IPresentacion _presentaciones;
    private IProducto _productos;
    private IRolPersona _rolpersonas;
    private ITipoContacto _tipocontactos;
    private ITipoDocumento _tipodocumento;
    private ITipoMovInventario _tipomovinventarios;
    private ITipoPersona _tipopersonas;
    private IUbicacionPersona _ubicacionpersonas;
    private readonly FarmaciaContext _context;

    public UnitOfWork(FarmaciaContext context)
    {
        _context = context;
    }
    public ICiudad Ciudades
    {
        get
        {
            if (_ciudades == null)
            {
                _ciudades = new CiudadRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _ciudades;
        }
    }
    public IContactoPersona ContactoPersonas
    {
        get
        {
            if (_contactopersonas == null)
            {
                _contactopersonas = new ContactoPersonaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _contactopersonas;
        }
    }
    public IDepartamento Departamentos
    {
        get
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _departamentos;
        }
    }
    public IDetalleMovInventario DetalleMovInventarios
    {
        get
        {
            if (_detallemovinvetarios == null)
            {
                _detallemovinvetarios = new DetalleMovInventarioRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _detallemovinvetarios;
        }
    }
    public IFactura Facturas
    {
        get
        {
            if (_facturas == null)
            {
                _facturas = new FacturaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _facturas;
        }
    }
    public IFormaPago FormaPagos
    {
        get
        {
            if (_formatopagos == null)
            {
                _formatopagos = new FormaPagoRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _formatopagos;
        }
    }
    public IInventario Inventarios
    {
        get
        {
            if (_inventarios == null)
            {
                _inventarios = new InventarioRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _inventarios;
        }
    }
    public IMarca Marcas
    {
        get
        {
            if (_marcas == null)
            {
                _marcas = new MarcaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _marcas;
        }
    }
    public IMovimientoInventario MovimientoInventarios
    {
        get
        {
            if (_movimientoinventarios == null)
            {
                _movimientoinventarios = new MovimientoInventarioRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _movimientoinventarios;
        }
    }
    public IPais Paises
    {
        get
        {
            if (_paises == null)
            {
                _paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _paises;
        }
    }
    public IPersona Personas
    {
        get
        {
            if (_personas == null)
            {
                _personas = new PersonaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _personas;
        }
    }
    public IPresentacion Presentaciones
    {
        get
        {
            if (_presentaciones == null)
            {
                _presentaciones = new PresentacionRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _presentaciones;
        }
    }
    public IProducto Productos
    {
        get
        {
            if (_productos == null)
            {
                _productos = new ProductoRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _productos;
        }
    }
    public IRolPersona RolPersonas
    {
        get
        {
            if (_rolpersonas == null)
            {
                _rolpersonas = new RolPersonaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _rolpersonas;
        }
    }
    public ITipoContacto TipoContactos
    {
        get
        {
            if (_tipocontactos == null)
            {
                _tipocontactos = new TipoContactoRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _tipocontactos;
        }
    }
    public ITipoDocumento TipoDocumentos
    {
        get
        {
            if (_tipodocumento == null)
            {
                _tipodocumento = new TipoDocumentoRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _tipodocumento;
        }
    }
    public ITipoMovInventario TipoMovInventarios
    {
        get
        {
            if (_tipomovinventarios == null)
            {
                _tipomovinventarios = new TipoMovInventarioRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _tipomovinventarios;
        }
    }
    public ITipoPersona TipoPersonas
    {
        get
        {
            if (_tipopersonas == null)
            {
                _tipopersonas = new TipoPersonaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _tipopersonas;
        }
    }
    public IUbicacionPersona UbicacionPersonas
    {
        get
        {
            if (_ubicacionpersonas == null)
            {
                _ubicacionpersonas = new UbicacionPersonaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _ubicacionpersonas;
        }
    }
    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
