using Microsoft.EntityFrameworkCore;
using MVCApp.Models;

namespace MVCApp
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }

        public DbSet<Villa> villas { get; set; }
        public DbSet<VillaAmenity> villaAmenities { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Casagrand" ,
                    Price = 300
                },
                new Villa
                {
                    Id = 2,
                    Name = "RainbowVistas",
                    Price = 200
                },
                new Villa
                {
                    Id = 3,
                    Name = "MarinaSkies",
                    Price = 400
                }

                );
            modelBuilder.Entity<VillaAmenity>().HasData(
                new VillaAmenity
                {
                    Id = 1,
                    VillaId = 1,
                    Name = "Pool"
                 
                },
                new VillaAmenity
                {
                    Id = 2,
                    VillaId = 1,
                    Name = "Gameboy"

                },
                new VillaAmenity
                {
                    Id = 3,
                    VillaId = 2,
                    Name = "Gym"

                },
                new VillaAmenity
                {
                    Id = 4,
                    VillaId = 2,
                    Name = "PlayCourt"

                },
                new VillaAmenity
                {
                    Id = 5,
                    VillaId = 3,
                    Name = "Security"

                },
                new VillaAmenity
                {
                    Id = 6,
                    VillaId = 3,
                    Name = "Shop"

                },
                new VillaAmenity
                {
                    Id = 7,
                    VillaId = 3,
                    Name = "Jacuzzi"

                }
                );
        }
    }
}
