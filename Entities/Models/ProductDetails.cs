using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProductDetails
    {
        [Key]
        [Required]
        public int ProductDetailsId { get; set; }
        [Required]
        public string? ProductExplanation { get; set; }
       

        public int? SizeId { get; set; }
        public Size? Size { get; set; }

        public int? ColorId { get; set; }
        public Color? Color { get; set; }

        public int? NumberId { get; set; }
        public Number? Number { get; set; }

        public int? TvId { get; set; }
        public ProductDetailTv? ProductDetailTv { get; set; }

        public int? WacthId { get; set; }
        public ProductDetailWatch? ProductDetailWatch { get; set; }

        public int? PhoneId { get; set; }
        public ProductDetailPhone? ProductDetailPhone { get; set; }

        public int? PcId { get; set; }
        public  ProductDetailPc? ProductDetailPc { get; set; }

        public int? ManWomenId { get; set; }
        public ProductDetailManWomen? ProductDetailManWomen { get; set; }

        public int? HeadPhoneId { get; set; }
        public ProductDetailHeadPhone? ProductDetailHeadPhone { get; set; }

        public int? ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
