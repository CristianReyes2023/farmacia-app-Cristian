using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class RolPersonaRepository : GenericRepository<RolPersona>, IRolPersona
{
    private readonly FarmaciaContext _context;

    public RolPersonaRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
