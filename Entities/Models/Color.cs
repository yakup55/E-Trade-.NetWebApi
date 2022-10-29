using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Color
    {
        [Key]
        [Required]
        public int ColorId { get; set; }
        [Required]
        public string? ColorName { get; set; }

        public ICollection<ProductDetails>? ProductDetails { get; set; }
    }
}
