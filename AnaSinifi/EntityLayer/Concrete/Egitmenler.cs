using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Egitmenler
    {
        [Key]
        public int EgitmenID { get; set; }
        public string EgitmenAdi { get; set; }
        public string? EgitmenAciklama { get; set; }
        public string? EgitmenGorsel { get; set; }
        public string? EgitmenFacebook { get; set; }
        public string? EgitmenTwitter { get; set; }
        public string? EgitmenInstagram { get; set; }
        public bool EgitmenStatus { get; set; }
    }
}
