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
    public class HeadPhoneDetailConfig : IEntityTypeConfiguration<ProductDetailHeadPhone>
    {
        public void Configure(EntityTypeBuilder<ProductDetailHeadPhone> builder)
        {
            builder.HasKey(x => x.HeadPhoneId);
            builder.Property(x => x.GurultuOnleme).IsRequired();
            builder.Property(x => x.BluetoothVersiyon).IsRequired();
            builder.Property(x => x.CiftTelefonDestegi).IsRequired();
            builder.Property(x => x.KullanimTipi).IsRequired();
            builder.Property(x => x.SuyaTereDayanikli).IsRequired();
    }
}
}
