using PlatformService.Data;
using PlatformService.Models;
namespace PlatformService.Repos
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;
        public PlatformRepo(AppDbContext context)
        {
            _context=context;
        }
        public void CreatPlatform(Platform platform)
        {
            if(platform==null)
            {
                throw new ArgumentNullException(nameof(platform));
            }
            _context.Platforms.Add(platform);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
           return _context.Platforms.ToList();
        }

        public Platform GetPlatform(int id)
        {
         return _context.Platforms.FirstOrDefault(p=>p.Id==id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >=0;
        }
    }
}