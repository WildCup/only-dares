using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DaresGacha.Dtos;

namespace DaresGacha
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Dare, DareGetDto>().ReverseMap();
            CreateMap<Dare, DareAddDto>().ReverseMap();
            CreateMap<Dare, DareUpdateDto>().ReverseMap();
            CreateMap<Dare, DareGetRandomDto>().ReverseMap();

        }
    }
}