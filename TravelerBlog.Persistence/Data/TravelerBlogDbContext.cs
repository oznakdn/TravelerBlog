using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelerBlog.Domain.Entities;

namespace TravelerBlog.Persistence.Data
{
    public class TravelerBlogDbContext : IdentityDbContext<User>
    {
        public TravelerBlogDbContext(DbContextOptions<TravelerBlogDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationPicture> LocationPictures { get; set; }
        public DbSet<UserPicture> UserPictures { get; set; }
        public DbSet<FlagPicture> FlagPictures { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Advice> Advices { get; set; }

    }
}
