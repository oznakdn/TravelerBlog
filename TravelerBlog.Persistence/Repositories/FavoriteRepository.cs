using TravelerBlog.Application.Repositories;
using TravelerBlog.Domain.Entities;
using TravelerBlog.Persistence.Data;
using TravelerBlog.Persistence.Repository;

namespace TravelerBlog.Persistence.Repositories
{
    public class FavoriteRepository : RepositoryBase<Favorite>, IFavoriteRepository
    {
        public FavoriteRepository(TravelerBlogDbContext context) : base(context)
        {
        }
    }
}
