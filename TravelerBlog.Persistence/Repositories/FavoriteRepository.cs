namespace TravelerBlog.Persistence.Repositories
{
    public class FavoriteRepository : RepositoryBase<Favorite>, IFavoriteRepository
    {
        public FavoriteRepository(TravelerBlogDbContext context) : base(context)
        {
        }
    }
}
