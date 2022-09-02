using TravelerBlog.Application.Repositories;
using TravelerBlog.Domain.Entities;
using TravelerBlog.Persistence.Data;
using TravelerBlog.Persistence.Repository;

namespace TravelerBlog.Persistence.Repositories
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        public LocationRepository(TravelerBlogDbContext context) : base(context)
        {
        }
    }
}
