using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using CsvHelper;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class FacturaRepository : GenericRepository<Factura>, IFactura
{
    private readonly FarmaciaContext _context;

    public FacturaRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
