using DAL.Context;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class UOW : IUOW
    {

        private readonly ShoesDbContext _context;
        private IShoesRepository _shoesRepository;

        public UOW(ShoesDbContext context)
        {
            _context = context;

        }

        public IShoesRepository Shoes
        {
            get
            {
                if (_shoesRepository == null)
                    _shoesRepository = new ShoesRepository(_context);

                return _shoesRepository;
            }
        }



        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
