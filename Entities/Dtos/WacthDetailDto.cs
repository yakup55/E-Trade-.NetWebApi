using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class WacthDetailDto
    {
        public string AdımSayar { get; set; }
        public string GPS { get; set; }
        public string KalpRitmiOlcme { get; set; }
        public string Kamera { get; set; }
        public string SesliGorusme { get; set; }
        public string SuGecirme { get; set; }
        public string UykuTakibi { get; set; }
        public string UyumluMarka { get; set; }

    }
    public class TvDetailDto
    {
        public string DahiliUyduAlici { get; set; }
        public string EkranEbati { get; set; }
        public string EkranFormati { get; set; }
        public string Wifi { get; set; }
        public string Kurulum { get; set; }
        public string PcBaglantisi { get; set; }
        public string HdmiGirisleri { get; set; }
    }
}
