namespace TravelerBlog.Persistence.Repositories
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(TravelerBlogDbContext context) : base(context)
        {
        }
    }
}
