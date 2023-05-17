using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ders
    {
        [Key]
        public int DersID { get; set; }
        public string DersAdi { get; set; }
        public string DersAciklama { get; set; }
        public string DersImage { get; set; }



    }
}
