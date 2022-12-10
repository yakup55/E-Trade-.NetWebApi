﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete.Config
{
    public class PcDetailConfig : IEntityTypeConfiguration<ProductDetailPc>
    {
        public void Configure(EntityTypeBuilder<ProductDetailPc> builder)
        {
            builder.HasKey(x => x.ProductDetailPcId);
            builder.Property(x => x.SDDKapasite).IsRequired();
            builder.Property(x => x.İslemciTipi).IsRequired();
            builder.Property(x => x.İslemciNesli).IsRequired();
            builder.Property(x => x.Ram).IsRequired();
            builder.Property(x => x.RamTipi).IsRequired();
            builder.Property(x => x.EkranCozunurlugu).IsRequired();
            builder.Property(x => x.EkranYenilemeHizi).IsRequired();
            builder.Property(x => x.EkranBoyutu).IsRequired();
            builder.Property(x => x.BellekHizi).IsRequired();
            builder.Property(x => x.CihazAgirligi).IsRequired();
    }
    }
}
