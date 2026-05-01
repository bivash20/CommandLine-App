using AutoMapper;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfiles : Profile
    {
        public PlatformsProfiles()
        {
            //Source -> Target
            CreateMap<Platform, DTOs.PlatformReadDto>();
            CreateMap<DTOs.PlatformCreateDto, Platform>();
        }
    }
}