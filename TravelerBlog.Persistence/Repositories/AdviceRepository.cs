using TravelerBlog.Application.Repositories;
using TravelerBlog.Domain.Entities;
using TravelerBlog.Persistence.Data;
using TravelerBlog.Persistence.Repository;

namespace TravelerBlog.Persistence.Repositories
{
    public class AdviceRepository : RepositoryBase<Advice>, IAdviceRepository
    {
        public AdviceRepository(TravelerBlogDbContext context) : base(context)
        {

        }
    }
}
