using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IProfileRepo
    {
        bool SaveChanges();

        IEnumerable<Profile> GetAllProfiles();
        Profile GetProfileById(Guid id);
        void CreateProfile(Profile profile);
    }
}
