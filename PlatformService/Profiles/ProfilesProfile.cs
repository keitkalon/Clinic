namespace PlatformService.Profiles
{
    public class ProfilesProfile : AutoMapper.Profile
    {
        public ProfilesProfile()
        {
            //CreateMap<Source --> Target>
            CreateMap<Models.Profile, Dtos.ProfileReadDtos>();
            CreateMap<Dtos.ProfileCreateDtos, PlatformService.Models.Profile>();
        }
    }
}
