using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class CategoryRepository : GenericRepository<Category>, ICategory
{
    private readonly FarmaciaContext _context;

    public CategoryRepository(FarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
