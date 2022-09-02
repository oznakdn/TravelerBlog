using TravelerBlog.Application.Repositories;
using TravelerBlog.Domain.Entities;
using TravelerBlog.Persistence.Data;
using TravelerBlog.Persistence.Repository;

namespace TravelerBlog.Persistence.Repositories
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(TravelerBlogDbContext context) : base(context)
        {
        }
    }
}
