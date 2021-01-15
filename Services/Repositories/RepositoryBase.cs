using DAL.Context;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ShoesDbContext Context { get; set; }

        public RepositoryBase(ShoesDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<T> FindAll()
        {
            return Context.Set<T>();
        }
         public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }
    }
}
