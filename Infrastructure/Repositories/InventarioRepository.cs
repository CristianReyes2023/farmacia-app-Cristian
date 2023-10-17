using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class InventarioRepository : GenericRepositoryString<Inventario>, IInventario
{
    private readonly FarmaciaContext _context;

    public InventarioRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
