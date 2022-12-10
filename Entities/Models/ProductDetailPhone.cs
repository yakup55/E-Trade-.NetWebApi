using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProductDetailPhone
    {
        [Key]
        [Required]
        public int ProductDetailPhoneId { get; set; }

        public string? bluetooth { get; set; }
        public string? cifthat { get; set; }
        public string? dahilihafiza { get; set; }
        public string? kameracözünürlügü { get; set; }
        public string? pilgücü { get; set; }
        public string? yüztanıma { get; set; }
        public string? parmakizi { get; set; }

        public ICollection<ProductDetails>? ProductDetails { get; set; }
    }
}
