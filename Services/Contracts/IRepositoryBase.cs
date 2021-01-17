using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();

        T Get(int Id);
    }
}
