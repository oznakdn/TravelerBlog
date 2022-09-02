namespace TravelerBlog.Persistence.Repositories
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        public LocationRepository(TravelerBlogDbContext context) : base(context)
        {
        }
    }
}
