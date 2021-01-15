using AutoMapper;
using BLL.DTO.Shoes;
using BLL.Interfaces;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Operations
{
    public class ShoesOperation : IShoesOperation
    {
        private readonly IUOW _uow;
        private IMapper _mapper;

        public ShoesOperation(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IEnumerable<ShoesListDTO> GetAll()
        {
            var shoes =  _uow.Shoes.GetAll();
            return _mapper.Map<IEnumerable<ShoesListDTO>>(shoes);
        }
    }
}
