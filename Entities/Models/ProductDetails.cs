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

        public int? ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
