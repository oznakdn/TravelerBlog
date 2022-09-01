using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelerBlog.Core.Entity;

namespace TravelerBlog.Domain.Entities
{
    public class Country : EntityBase
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        public string CountryName { get; set; }
        public FlagPicture FlagPicture { get; set; }
        public ICollection<City> Cities { get; set; }


        [NotMapped]
        public override bool IsActive { get => base.IsActive; set => base.IsActive = value; }



    }
}
