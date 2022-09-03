using System.Linq;

namespace TravelerBlog.Persistence.Repositories
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        private readonly TravelerBlogDbContext _context;
        public LocationRepository(TravelerBlogDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Location>> GetAllWithIncludeAndThanInclude(bool isChangeTracking, Expression<Func<Location, bool>> predicate = null)
        {
            if(isChangeTracking)
            {
               return predicate == null ? await _context.Locations.Include(p => p.LocationPictures).Include(p => p.Posts).ThenInclude(u => u.User).ToListAsync()
                                  : await _context.Locations.Where(predicate).Include(p => p.LocationPictures).Include(p => p.Posts).ThenInclude(u => u.User).ToListAsync();
            }
            else
            {
                return predicate == null ? await _context.Locations.Include(p => p.LocationPictures).Include(p => p.Posts).ThenInclude(u => u.User).AsNoTracking().ToListAsync()
                                  : await _context.Locations.Where(predicate).Include(p => p.LocationPictures).Include(p => p.Posts).ThenInclude(u => u.User).AsNoTracking().ToListAsync();
            }
        }
    }
}
