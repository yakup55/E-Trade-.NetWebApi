using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProductDetailWatch
    {
        [Key]
        [Required]
        public int ProductDetailWatchId { get; set; }

        public string? AdımSayar { get; set; }
        public string? GPS { get; set; }
        public string? KalpRitmiOlcme { get; set; }
        public string? Kamera { get; set; }
        public string? SesliGorusme { get; set; }
        public string? SuGecirme { get; set; }
        public string? UykuTakibi { get; set; }
        public string? UyumluMarka { get; set; }

        public ICollection<ProductDetails>? ProductDetails { get; set; }
    }
}
