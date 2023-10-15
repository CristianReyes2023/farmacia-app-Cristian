using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class FormatoPagoRepository : GenericRepository<FormaPago>, IFormaPago
{
    private readonly FarmaciaContext _context;

    public FormatoPagoRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
