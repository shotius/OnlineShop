using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Dictionary
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool HasType { get; set; }
        public bool HasBrand { get; set; }
        public ICollection<Shoes> ShoesTypes { get; set; }
        public ICollection<Shoes> ShoesBrands { get; set; }
    }
}
