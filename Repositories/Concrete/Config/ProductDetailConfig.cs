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
            //hasone eklemeye çalış
            builder.HasData(
              new ProductDetails { ProductDetailsId = 1,SizeId=1,ColorId=1,ProductExplanation="ddd" },
              new ProductDetails { ProductDetailsId = 2,SizeId=2,ColorId=2, ProductExplanation = "ddd" },
              new ProductDetails { ProductDetailsId = 3,SizeId=3,ColorId=3, ProductExplanation = "ddd" },
              new ProductDetails { ProductDetailsId = 4,SizeId=4,ColorId=4, ProductExplanation = "ddd" },
              new ProductDetails { ProductDetailsId = 5,SizeId=1,ColorId=4, ProductExplanation = "ddd" },
              new ProductDetails { ProductDetailsId = 6,SizeId=3,ColorId=5, ProductExplanation = "ddd" }
                );
            builder.HasOne(x => x.Product).WithOne(x => x.ProductDetails).HasForeignKey<ProductDetails>(x => x.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x=>x.Color).WithMany(x=>x.ProductDetails).HasForeignKey(x=>x.ColorId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Size).WithMany(x => x.ProductDetails).HasForeignKey(x => x.SizeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
