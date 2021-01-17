using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Repositories
{
    public class ShoesRepository : RepositoryBase<Shoes>, IShoesRepository
    {
        public ShoesRepository(ShoesDbContext context) : base(context) { }

        public IEnumerable<Shoes> GetAll()
        {
            return Context.ManyShoes.Include(x => x.Brand);
        }

    }
}
