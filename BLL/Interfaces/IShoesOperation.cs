using BLL.DTO.Shoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IShoesOperation
    {
        public IEnumerable<ShoesListDTO> GetAll();
    }
}
