using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete.Config
{
    public class ProductCommentConfig : IEntityTypeConfiguration<ProductComment>
    {
        public void Configure(EntityTypeBuilder<ProductComment> builder)
        {
            builder.HasKey(x => x.ProductCommentId);
            //PRODUCT-COMMENT
            builder.HasOne(x => x.Product).WithMany(x => x.ProductComments).HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            //COMMENT-PRODUCT
            builder.HasOne(x=>x.Comment).WithMany(x=>x.ProductComments).HasForeignKey(x=>x.CommentId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
                new ProductComment
                {
                    ProductCommentId = 1,
                    ProductId = 1,
                    CommentId = 2
                },
                 new ProductComment
                 {
                     ProductCommentId = 2,
                     ProductId = 2,
                     CommentId = 1
                 },
                  new ProductComment
                  {
                      ProductCommentId = 3,
                      ProductId = 3,
                      CommentId = 3
                  }
                ) ;
        }
    }
}
