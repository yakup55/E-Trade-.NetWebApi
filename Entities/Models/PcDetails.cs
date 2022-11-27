using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PcDetails
    {
        [Key]
        [Required]
        public int PcDetailsId { get; set; }
        [Required]
        public string? SDDKapasite { get; set; }
        [Required]
        public string? RamTipi { get; set; }
        [Required]
        public string? Ram { get; set; }
        [Required]
        public string? EkranCozunurlugu { get; set; }
        [Required]
        public string? İslemciNesli { get; set; }
        [Required]
        public string? İslemciTipi { get; set; }
        [Required]
        public string? EkranYenilemeHizi { get; set; }
        [Required]
        public string? EkranBoyutu { get; set; }
        [Required]
        public string? BellekHızı { get; set; }
        [Required]
        public string? CihazAgirligi { get; set; }


        public int? ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
