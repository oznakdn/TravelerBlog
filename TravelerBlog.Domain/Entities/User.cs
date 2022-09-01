using Microsoft.AspNetCore.Identity;

namespace TravelerBlog.Domain.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            Posts = new HashSet<Post>();
            Advices = new HashSet<Advice>();
            Favorites = new HashSet<Favorite>();
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public LocationPicture Picture { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<Advice> Advices { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
    }
}
