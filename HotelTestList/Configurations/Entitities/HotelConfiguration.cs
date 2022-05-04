using HotelTestList.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelTestList.Configurations.Entitities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
