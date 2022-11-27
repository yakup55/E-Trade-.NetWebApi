using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Product
    {
        public Product(int productId, string? productName, string? productImage, int productPrice, DateTime productDate)
        {
            ProductId = productId;
            ProductName = productName;
            ProductImage = productImage;
            ProductPrice = productPrice;
            ProductDate = productDate;
        }
        public Product()
        {

        }
        [Key]
        [Required]
        public int ProductId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(1000)]
        public string? ProductName { get; set; }
        public string? ProductImage { get; set; }
        public int ProductPrice { get; set; }
        public DateTime ProductDate { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<ProductComment>? ProductComments { get; set; }

        public ProductDetails? ProductDetails { get; set; }
        public PcDetails? PcDetails { get; set; }

        public override string ToString()
        {
            return $"{ProductName} {ProductPrice} {ProductImage} {ProductDate}";
        }
    }
}
