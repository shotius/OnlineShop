﻿using BLL.DTO.Shoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ShoesListVM
    {
        public IEnumerable<ShoesListDTO> Shoes { get; set; }
    }
}
