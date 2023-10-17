using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
}
