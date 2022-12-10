using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProductDetailPc
    {
        [Key]
        [Required]
        public int ProductDetailPcId { get; set; }

        public string? SDDKapasite { get; set; }
        public string? RamTipi { get; set; }
        public string? Ram { get; set; }
        public string? EkranCozunurlugu { get; set; }
        public string? İslemciNesli { get; set; }
        public string? İslemciTipi { get; set; }
        public string? EkranYenilemeHizi { get; set; }
        public string? EkranBoyutu { get; set; }
        public string? BellekHizi { get; set; }
        public string? CihazAgirligi { get; set; }

        public ICollection<ProductDetails>? ProductDetails { get; set; }
    }
}
