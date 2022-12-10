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
            builder.HasData(
              new ProductDetails
              {
                  ProductDetailsId = 1,
                  ProductExplanation = "ddd"

              }
                );
            builder.HasOne(x => x.Product).WithOne(x => x.ProductDetails).HasForeignKey<ProductDetails>(x => x.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Color).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ColorId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Size).WithMany(x => x.ProductDetails).HasForeignKey(x => x.SizeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Number).WithMany(x => x.ProductDetails).HasForeignKey(x => x.NumberId).OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(x => x.ProductDetailPc).WithMany(x => x.ProductDetails).HasForeignKey(x => x.PcId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.ProductDetailWatch).WithMany(x => x.ProductDetails).HasForeignKey(x => x.WacthId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.ProductDetailTv).WithMany(x => x.ProductDetails).HasForeignKey(x => x.TvId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.ProductDetailPhone).WithMany(x => x.ProductDetails).HasForeignKey(x => x.PhoneId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.ProductDetailManWomen).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ManWomenId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.ProductDetailHeadPhone).WithMany(x => x.ProductDetails).HasForeignKey(x => x.HeadPhoneId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
