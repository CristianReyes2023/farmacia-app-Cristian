using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class MovimientoInventarioRepository : GenericRepository<MovimientoInventario>, IMovimientoInventario
{
    private readonly FarmaciaContext _context;

    public MovimientoInventarioRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}