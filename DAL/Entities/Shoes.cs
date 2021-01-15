using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Shoes
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int BrandId { get; set; }
        public string Color { get; set; }
        public string Picture { get; set; }
        public string ProductionCountry { get; set; }
        public decimal Price { get; set; }

        public Dictionary Type { get; set; }
        public Dictionary Brand { get; set; }

    }
}
