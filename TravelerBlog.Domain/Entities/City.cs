using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelerBlog.Core.Entity;

namespace TravelerBlog.Domain.Entities
{
    public class City:EntityBase
    {
        public City()
        {
            Locations = new HashSet<Location>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set ; }
        public string CityName { get; set; }
        public ICollection<Location> Locations { get; set; }


        [NotMapped]
        public override bool IsActive { get => base.IsActive; set => base.IsActive = value; }
    }
}
