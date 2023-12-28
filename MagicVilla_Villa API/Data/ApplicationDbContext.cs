using MagicVilla_Villa_API.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_Villa_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        
        }
        public DbSet<Villa> Villas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "With about 270 sq. meters, on three levels, the villa, which is accessed through remote-controlled electric gates, " +
                    "features on the ground floor a large and bright 70 m² Living room comfortably furnished, with a baby grand piano and a flat panel " +
                    "TV (HD, with French channels as well as Netflix)",
                    ImageUrl = "https://unsplash.com/photos/a-swimming-pool-with-lounge-chairs-and-palm-trees-HDX63jhsD3o",
                    Occupancy = 5,
                    Rate = 5,
                    Sqft = 500,
                    Amenity= "",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Royal Villa",
                    Details = "With about 270 sq. meters, on three levels, the villa, which is accessed through remote-controlled electric gates, " +
                    "features on the ground floor a large and bright 70 m² Living room comfortably furnished, with a baby grand piano and a flat panel " +
                    "TV (HD, with French channels as well as Netflix)",
                    ImageUrl = "https://unsplash.com/photos/a-swimming-pool-with-lounge-chairs-and-palm-trees-HDX63jhsD3o",
                    Occupancy = 5,
                    Rate = 5,
                    Sqft = 500,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Royal Villa",
                    Details = "With about 270 sq. meters, on three levels, the villa, which is accessed through remote-controlled electric gates, " +
                    "features on the ground floor a large and bright 70 m² Living room comfortably furnished, with a baby grand piano and a flat panel " +
                    "TV (HD, with French channels as well as Netflix)",
                    ImageUrl = "https://unsplash.com/photos/a-swimming-pool-with-lounge-chairs-and-palm-trees-HDX63jhsD3o",
                    Occupancy = 5,
                    Rate = 5,
                    Sqft = 500,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Royal Villa",
                    Details = "With about 270 sq. meters, on three levels, the villa, which is accessed through remote-controlled electric gates, " +
                    "features on the ground floor a large and bright 70 m² Living room comfortably furnished, with a baby grand piano and a flat panel " +
                    "TV (HD, with French channels as well as Netflix)",
                    ImageUrl = "https://unsplash.com/photos/a-swimming-pool-with-lounge-chairs-and-palm-trees-HDX63jhsD3o",
                    Occupancy = 5,
                    Rate = 5,
                    Sqft = 500,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Royal Villa",
                    Details = "With about 270 sq. meters, on three levels, the villa, which is accessed through remote-controlled electric gates, " +
                    "features on the ground floor a large and bright 70 m² Living room comfortably furnished, with a baby grand piano and a flat panel " +
                    "TV (HD, with French channels as well as Netflix)",
                    ImageUrl = "https://unsplash.com/photos/a-swimming-pool-with-lounge-chairs-and-palm-trees-HDX63jhsD3o",
                    Occupancy = 5,
                    Rate = 5,
                    Sqft = 500,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                }
            );
        }
    }
}
