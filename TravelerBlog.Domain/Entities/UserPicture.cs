using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelerBlog.Core.Entity;

namespace TravelerBlog.Domain.Entities
{
    public class UserPicture:EntityBase
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get ; set ; }
        public string FileName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public Guid UserId { get; set; }
        public User User { get; set; }

        public override string? Description { get; set; }
    }
}
