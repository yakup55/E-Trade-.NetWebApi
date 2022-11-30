using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete.Config
{
    public class ProductDetailConfig : IEntityTypeConfiguration<ProductDetails>
    {
        public void Configure(EntityTypeBuilder<ProductDetails> builder)
        {
            builder.HasKey(x => x.ProductDetailsId);
            builder.Property(x => x.ProductExplanation).IsRequired();
            //pc
            builder.Property(x => x.EkranBoyutu).IsRequired();
            builder.Property(x => x.SDDKapasite).IsRequired();
            builder.Property(x => x.Ram).IsRequired();
            builder.Property(x => x.RamTipi).IsRequired();
            builder.Property(x => x.İslemciTipi).IsRequired();
            builder.Property(x => x.İslemciNesli).IsRequired();
            builder.Property(x => x.EkranYenilemeHizi).IsRequired();
            builder.Property(x => x.BellekHizi).IsRequired();
            builder.Property(x => x.CihazAgirligi).IsRequired();
            builder.Property(x => x.EkranCozunurlugu).IsRequired();

          //  Phone
            builder.Property(x => x.bluetooth).IsRequired();
            builder.Property(x => x.cifthat).IsRequired();
            builder.Property(x => x.dahilihafiza).IsRequired();
            builder.Property(x => x.kameracözünürlügü).IsRequired();
            builder.Property(x => x.pilgücü).IsRequired();
            builder.Property(x => x.yüztanıma).IsRequired();
            builder.Property(x => x.parmakizi).IsRequired();
          //  Bag Shoes...
            builder.Property(x => x.AyakkabiTipi).IsRequired();
            builder.Property(x => x.Malzeme).IsRequired();
            builder.Property(x => x.Cinsiyet).IsRequired();
            builder.Property(x => x.YakaStili).IsRequired();
            builder.Property(x => x.Tipi).IsRequired();

            //Watch
            builder.Property(x => x.AdımSayar).IsRequired();
            builder.Property(x => x.GPS).IsRequired();
            builder.Property(x => x.KalpRitmiOlcme).IsRequired();
            builder.Property(x => x.Kamera).IsRequired();
            builder.Property(x => x.SesliGorusme).IsRequired();
            builder.Property(x => x.SuGecirme).IsRequired();
            builder.Property(x => x.UykuTakibi).IsRequired();
            builder.Property(x => x.UyumluMarka).IsRequired();

            //HEADPHONE
            builder.Property(x => x.GurultuOnleme).IsRequired();
            builder.Property(x => x.BluetoothVersiyon).IsRequired();
            builder.Property(x => x.CiftTelefonDestegi).IsRequired();
            builder.Property(x => x.SuyaTereDayanikli).IsRequired();

            //TV
            builder.Property(x => x.DahiliUyduAlici).IsRequired();
            builder.Property(x => x.EkranEbati).IsRequired();
            builder.Property(x => x.EkranFormati).IsRequired();
            builder.Property(x => x.Wifi).IsRequired();
            builder.Property(x => x.PcBaglantisi).IsRequired();
            builder.Property(x => x.HdmiGirisleri).IsRequired();

            builder.HasData(
              new ProductDetails { 
                  ProductDetailsId = 1,
                  EkranBoyutu = "", 
                  SDDKapasite = "", 
                  Ram = "", 
                  RamTipi = "", 
                  İslemciTipi = "",
                  İslemciNesli = "",
                  EkranYenilemeHizi = "",
                  EkranCozunurlugu = "",
                  BellekHizi = "", 
                  CihazAgirligi = "",

                  bluetooth = "",
                  cifthat = "",
                  dahilihafiza = "",
                  kameracözünürlügü = "",
                  pilgücü = "",
                  yüztanıma = "",
                  parmakizi = "",

                  AyakkabiTipi = "",
                  Malzeme = "",
                  Cinsiyet = "",
                  YakaStili = "",
                  Tipi = "",

                  AdımSayar = "",
                  GPS = "",
                  KalpRitmiOlcme = "",
                  Kamera = "",
                  SesliGorusme = "",
                  SuGecirme = "",
                  UykuTakibi = "",
                  UyumluMarka = "",

                  GurultuOnleme="",
                  BluetoothVersiyon="",
                  CiftTelefonDestegi ="",
                  KullanimTipi="",
                  SuyaTereDayanikli="",



                  DahiliUyduAlici="",
                  EkranEbati="",
                  EkranFormati="",
                  Wifi="",
                  Kurulum="",
                  PcBaglantisi="",
                  HdmiGirisleri="",


                  SizeId = 1, 
                  ColorId = 1,
                  NumberId = 1,
                  ProductExplanation = "ddd"
              }
                ) ;
            builder.HasOne(x => x.Product).WithOne(x => x.ProductDetails).HasForeignKey<ProductDetails>(x => x.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Color).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ColorId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Size).WithMany(x => x.ProductDetails).HasForeignKey(x => x.SizeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Number).WithMany(x => x.ProductDetails).HasForeignKey(x => x.NumberId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Product).WithOne(x => x.ProductDetails).HasForeignKey<ProductDetails>(x => x.ProductId)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
