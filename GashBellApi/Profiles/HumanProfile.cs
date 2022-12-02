using AutoMapper;
using GashBellApi.Data.Dtos.Human;
using GashBellApi.Models;

namespace GashBellApi.Profiles
{
    public class HumanProfile : Profile
    {
        public HumanProfile()
        {
            CreateMap<CreateHumanDto, Human>();
            CreateMap<Human, ReadHumanDto>();
            CreateMap<Human, UpdateHumanDto>();
        }

    }
}
