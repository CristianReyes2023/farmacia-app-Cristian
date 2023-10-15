using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly FarmaciaContext _context;

    public PaisRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
