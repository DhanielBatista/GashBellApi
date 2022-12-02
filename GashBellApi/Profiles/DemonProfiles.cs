using AutoMapper;
using GashBellApi.Data.Dtos.Demon;
using GashBellApi.Models;

namespace GashBellApi.Profiles
{
    public class DemonProfile : Profile
    {
        public DemonProfile()
        {
            CreateMap<CreateDemonDto, Demon>();
            CreateMap<Demon, ReadDemonDto>();
            CreateMap<Demon, UpdateDemonDto>();
        }

    }
}