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
    public class DetailWatchConfig : IEntityTypeConfiguration<ProductDetailWatch>
    {
        public void Configure(EntityTypeBuilder<ProductDetailWatch> builder)
        {
            builder.HasKey(x => x.ProductDetailWatchId);
            builder.Property(x => x.AdımSayar).IsRequired();
            builder.Property(x => x.GPS).IsRequired();
            builder.Property(x => x.KalpRitmiOlcme).IsRequired();
            builder.Property(x => x.Kamera).IsRequired();
            builder.Property(x => x.SesliGorusme).IsRequired();
            builder.Property(x => x.SuGecirme).IsRequired();
            builder.Property(x => x.UykuTakibi).IsRequired();
            builder.Property(x => x.UyumluMarka).IsRequired();


        }
    }
}
