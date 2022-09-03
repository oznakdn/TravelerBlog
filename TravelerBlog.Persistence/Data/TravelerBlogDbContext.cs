using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TravelerBlog.Persistence.Data
{
    public class TravelerBlogDbContext : IdentityDbContext<User>
    {
        public TravelerBlogDbContext(DbContextOptions<TravelerBlogDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationPicture> LocationPictures { get; set; }
        public DbSet<UserPicture> UserPictures { get; set; }
        public DbSet<FlagPicture> FlagPictures { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Advice> Advices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = new Guid("7e21177b-f8dd-448b-9a42-55e7336b1881"),
                    CountryName = "Turkey",
                    Description = "Turkey,[a] officially the Republic of Türkiye,[b] is a transcontinental country located mainly on the Anatolian Peninsula in Western Asia, with a small portion on the Balkan Peninsula in Southeast Europe. It shares borders with the Black Sea to the north; Georgia to the northeast; Armenia, Azerbaijan, and Iran to the east; Iraq to the southeast; Syria and the Mediterranean Sea to the south; the Aegean Sea to the west; and Greece and Bulgaria to the northwest. Cyprus is located off the south coast. Turks form the vast majority of the nation's population and Kurds are the largest minority.[4] Ankara is Turkey's capital, while Istanbul is its largest city and financial centre.",
                    IsActive = true,
                    IsDeleted = false,
                });

            builder.Entity<Location>().HasData(

                    new Location
                    {
                        Id = new Guid("2db8c9d8-40a1-445c-bd3e-f126cdf49352"),
                        LocationName = "Pamukkale",
                        Description = "Kent Kaplıcaları ve akan sulardan kalan karbonat minerallerin teraslarını, travertenlerini kapsamaktadır.",
                        City = "Denizli",
                        Ditrict = String.Empty,
                        CountryId = new Guid("7e21177b-f8dd-448b-9a42-55e7336b1881"),
                        IsActive = true,
                        IsDeleted = false
                    },
                        new Location
                        {
                            Id = new Guid("7583ba2d-1c79-48d0-b49d-fc973aa0a808"),
                            LocationName = "Topkapi Sarayi",
                            Description = "Topkapı Sarayı, İstanbul Sarayburnu'nda, Osmanlı İmparatorluğu'nun 600 yıllık tarihinin 400 yılı boyunca, devletin idare merkezi olarak kullanılan ve Osmanlı padişahlarının yaşadığı saraydır. ",
                            City = "Istanbul",
                            Ditrict = "Fatih",
                            CountryId = new Guid("7e21177b-f8dd-448b-9a42-55e7336b1881"),
                            IsActive = true,
                            IsDeleted = false

                        });


            builder.Entity<LocationPicture>().HasData(

             new LocationPicture
             {
                 Id = new Guid("e96ecdee-1207-4bc4-a03a-4fb1143b5f6e"),
                 FileName = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c6/Pamukkale_02.jpg/1280px-Pamukkale_02.jpg",
                 IsActive = true,
                 IsDeleted = false,
                 LocationId = new Guid("2db8c9d8-40a1-445c-bd3e-f126cdf49352")
             },
             new LocationPicture
             {
                 Id = new Guid("8d65f867-353c-4afe-8dcb-be36012fb2f4"),
                 FileName = "https://muzeler.org/images/google-place-images/topkapi-sarayi-muzesi.jpg",
                 IsActive = true,
                 IsDeleted = false,
                 LocationId = new Guid("7583ba2d-1c79-48d0-b49d-fc973aa0a808")
             });



            base.OnModelCreating(builder);
        }

    }
}
