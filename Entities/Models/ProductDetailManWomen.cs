using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProductDetailManWomen
    {
        [Key]
        [Required]
        public int ProductDetailManWomenId { get; set; }

        public string? AyakkabiTipi { get; set; }
        public string? Malzeme { get; set; }
        public string? Cinsiyet { get; set; }
        public string? YakaStili { get; set; }
        public string? Tipi { get; set; }

        public ICollection<ProductDetails>? ProductDetails { get; set; }
    }
}
