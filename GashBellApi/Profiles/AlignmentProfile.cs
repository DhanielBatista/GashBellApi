using GashBellApi.Data.Dtos.Alignment;
using GashBellApi.Models;
using AutoMapper;

namespace GashBellApi.Profiles
{
    public class AlignmentProfile : Profile
    {
        public AlignmentProfile()
        {
            CreateMap<CreateAlignmentDto, Alignment>();
            CreateMap<Alignment, ReadAlignmentDto>();
            CreateMap<Alignment, UpdateAlignmentDto>();
        }
    }
}
