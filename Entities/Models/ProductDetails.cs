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

        //PC DETAİLS
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
        public string? BellekHizi { get; set; }
        [Required]
        public string? CihazAgirligi { get; set; }

        //PHONE DETAİLS
        [Required]
        public string? bluetooth { get; set; }
        [Required]
        public string? cifthat { get; set; }
        [Required]
        public string? dahilihafiza { get; set; }
        [Required]
        public string? kameracözünürlügü { get; set; }
        [Required]
        public string? pilgücü { get; set; }
        [Required]
        public string? yüztanıma { get; set; }
        [Required]
        public string? parmakizi { get; set; }

        //SHOES VE BAG SWEAT JACKET DETAİLS
        [Required]
        public string? AyakkabiTipi { get; set; }
        [Required]
        public string? Malzeme { get; set; }
        [Required]
        public string? Cinsiyet { get; set; }
        [Required]
        public string? YakaStili { get; set; }
        [Required]
        public string? Tipi { get; set; }

        //WATCH DETAİL
        [Required]
        public string? AdımSayar { get; set; }
        [Required]
        public string? GPS { get; set; }
        [Required]
        public string? KalpRitmiOlcme { get; set; }
        [Required]
        public string? Kamera { get; set; }
        [Required]
        public string? SesliGorusme { get; set; }
        [Required]
        public string? SuGecirme { get; set; }
        [Required]
        public string? UykuTakibi { get; set; }
        [Required]
        public string? UyumluMarka { get; set; }


        public int? ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
