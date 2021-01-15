using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO.Shoes
{
    public class ShoesListDTO
    {
        public int Id { get; set; }
       // public string Type { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Picture { get; set; }
        public string ProductionCountry { get; set; }
        public decimal Price { get; set; }

    }
}
