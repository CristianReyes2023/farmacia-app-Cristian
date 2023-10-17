using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersona
{
    private readonly FarmaciaContext _context;

    public TipoPersonaRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
