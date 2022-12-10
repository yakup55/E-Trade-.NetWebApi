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
    public class ManWomenDetailConfig : IEntityTypeConfiguration<ProductDetailManWomen>
    {
        public void Configure(EntityTypeBuilder<ProductDetailManWomen> builder)
        {
            builder.HasKey(x => x.ProductDetailManWomenId);
            builder.Property(x => x.AyakkabiTipi).IsRequired();
            builder.Property(x => x.Malzeme).IsRequired();
            builder.Property(x => x.Cinsiyet).IsRequired();
            builder.Property(x => x.YakaStili).IsRequired();
            builder.Property(x => x.Tipi).IsRequired();

               
    }
    }
}
