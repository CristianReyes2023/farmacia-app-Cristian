using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class ContactoPersonaRepository : GenericRepository<ContactoPersona>, IContactoPersona
{
    private readonly FarmaciaContext _context;

    public ContactoPersonaRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
