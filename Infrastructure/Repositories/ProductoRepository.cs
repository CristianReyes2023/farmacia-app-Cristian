using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class ProductoRepository : GenericRepository<Producto>, IProducto
{
    private readonly FarmaciaContext _context;

    public ProductoRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
