using AutoMapper;
using BLL.DTO.Shoes;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Shoes, ShoesListDTO>()
                .ForMember(dest =>
                 dest.Brand,
                 opt => opt.MapFrom(src => src.Brand.Title));
                 
        }
    }
}
