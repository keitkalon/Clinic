using PlatformService.Models;

namespace PlatformService.Data
{
    public class ProfileRepo : IProfileRepo
    {
        private readonly AppDbContext _context;

        public ProfileRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateProfile(Profile profile)
        {   
            if(profile == null)
            {
                throw new ArgumentNullException(nameof(profile));
            }
             _context.Profiles.Add(profile);
        }

        public IEnumerable<Profile> GetAllProfiles()
        {
            return _context.Profiles.ToList();
        }

        public Profile GetProfileById(Guid id)
        {
           return _context.Profiles.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        { 
            return (_context.SaveChanges() >= 0);
        }
    }
}
