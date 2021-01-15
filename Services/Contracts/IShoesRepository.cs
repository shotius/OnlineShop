using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IShoesRepository : IRepositoryBase<Shoes>
    {
        IEnumerable<Shoes> GetAll();
    }
}
