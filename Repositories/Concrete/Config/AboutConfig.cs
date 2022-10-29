using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete.Config
{
    public class AboutConfig : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(x => x.AboutId);
            builder.Property(x => x.AboutDetails).IsRequired();
            builder.Property(x => x.AboutImage).IsRequired();

            builder.HasData(
                new About
                {
                    AboutId = 1,
                    AboutDetails = "testtt",
                    AboutImage = "eeeeeeeeeeeeeeeeee"
                },
           new About()
           {
               AboutId = 2,
               AboutDetails = "testtt",
               AboutImage = "eeeeeeeeeeeeeeeeee"
           },
         new About()
         {
             AboutId = 3,
             AboutDetails = "testtt",
             AboutImage = "eeeeeeeeeeeeeeeeee"
         }

                );

        }
    }
}
