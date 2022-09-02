using TravelerBlog.Application.Repositories;
using TravelerBlog.Domain.Entities;
using TravelerBlog.Persistence.Data;
using TravelerBlog.Persistence.Repository;

namespace TravelerBlog.Persistence.Repositories
{
    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(TravelerBlogDbContext context) : base(context)
        {
        }
    }
}
