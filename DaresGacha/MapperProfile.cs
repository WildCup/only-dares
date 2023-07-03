using AutoMapper;
using DaresGacha.Dtos.Dare;
using DaresGacha.Dtos.Player;

namespace DaresGacha
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Dare, DareAddDto>().ReverseMap();
            CreateMap<Dare, DareDoneDto>().ReverseMap();
            CreateMap<Dare, DareGetDto>().ReverseMap();
            CreateMap<Dare, DareGetRandomDto>().ReverseMap();
            CreateMap<Dare, DareUpdateDto>().ReverseMap();

            CreateMap<Player, PlayerAddDto>().ReverseMap();
            CreateMap<Player, PlayerGetDto>().ReverseMap();
            CreateMap<Player, PlayerUpdateDto>().ReverseMap();
        }
    }
}