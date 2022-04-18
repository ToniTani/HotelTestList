using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelTestList.Data
{
    public class DatabaseContext : DbContext
    {


        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
              new Country
                {
                 Id = 1,
                 Name = "China",
                 ShortName = "CHN"
                },
              new Country
               {
                 Id = 2,
                 Name = "Finland",
                 ShortName = "FIN"
               },
              new Country
                {
                 Id = 3,
                 Name = "Sweden",
                 ShortName = "SWE"
                }

                );
            builder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "Jarmon Kuula",
                Address = "Rättikuja",
                CountryId = 1,
                Rating = 2.3
            },
            new Hotel
            {
                Id = 2,
                Name = "El Fombera",
                Address = "Janeiro",
                CountryId = 2,
                Rating = 3.3
            },
            new Hotel
            {
                Id = 3,
                Name = "Al Mundo Resort",
                Address = "Malmö",
                CountryId = 3,
                Rating = 4.3
            }

            );
        }
    }
}
