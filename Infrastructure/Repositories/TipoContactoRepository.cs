using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class TipoContactoRepository : GenericRepository<TipoContacto>, ITipoContacto
{
    private readonly FarmaciaContext _context;

    public TipoContactoRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
