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
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(

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
        }
    }
}
