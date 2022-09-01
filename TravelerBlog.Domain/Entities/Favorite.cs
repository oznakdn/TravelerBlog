using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TravelerBlog.Core.Entity;

namespace TravelerBlog.Domain.Entities
{
    public class Favorite:EntityBase
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }

        public Guid LocationId { get; set; }
        public Location Location { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
