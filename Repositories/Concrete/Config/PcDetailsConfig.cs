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

    public class PcDetailsConfig : IEntityTypeConfiguration<PcDetails>
    {
        public void Configure(EntityTypeBuilder<PcDetails> builder)
        {
            builder.HasKey(x => x.PcDetailsId);
            builder.Property(x => x.EkranBoyutu).IsRequired();
            builder.Property(x => x.SDDKapasite).IsRequired();
            builder.Property(x => x.Ram).IsRequired();
            builder.Property(x => x.RamTipi).IsRequired();
            builder.Property(x => x.İslemciTipi).IsRequired();
            builder.Property(x => x.İslemciNesli).IsRequired();
            builder.Property(x => x.EkranYenilemeHizi).IsRequired();
            builder.Property(x => x.BellekHızı).IsRequired();
            builder.Property(x => x.CihazAgirligi).IsRequired();
            builder.HasData(
              new PcDetails { PcDetailsId = 1, EkranBoyutu = "", SDDKapasite = "", Ram = "", RamTipi = "", İslemciTipi = "", İslemciNesli = "", EkranYenilemeHizi = "", BellekHızı = "", CihazAgirligi = "",EkranCozunurlugu="" },
              new PcDetails { PcDetailsId = 2, EkranBoyutu = "", SDDKapasite = "", Ram = "", RamTipi = "", İslemciTipi = "", İslemciNesli = "", EkranYenilemeHizi = "", BellekHızı = "", CihazAgirligi = "", EkranCozunurlugu = "" },
              new PcDetails { PcDetailsId = 3, EkranBoyutu = "", SDDKapasite = "", Ram = "", RamTipi = "", İslemciTipi = "", İslemciNesli = "", EkranYenilemeHizi = "", BellekHızı = "", CihazAgirligi = "", EkranCozunurlugu = "" },
              new PcDetails { PcDetailsId = 4, EkranBoyutu = "", SDDKapasite = "", Ram = "", RamTipi = "", İslemciTipi = "", İslemciNesli = "", EkranYenilemeHizi = "", BellekHızı = "", CihazAgirligi = "", EkranCozunurlugu = "" },
              new PcDetails { PcDetailsId = 5, EkranBoyutu = "", SDDKapasite = "", Ram = "", RamTipi = "", İslemciTipi = "", İslemciNesli = "", EkranYenilemeHizi = "", BellekHızı = "", CihazAgirligi = "", EkranCozunurlugu = "" }
                ) ;

            builder.HasOne(x => x.Product).WithOne(x => x.PcDetails).HasForeignKey<PcDetails>(x => x.ProductId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
