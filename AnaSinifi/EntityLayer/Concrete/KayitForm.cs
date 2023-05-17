using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class KayitForm
	{
		[Key]
		public int KayitID { get; set; }
		public string OgrenciAdSoyad { get; set; }
		public string VeliAdSoyad { get; set; }
		public string TelefonNo { get; set; }
		public string Mail { get; set; }
		public string Mesaj { get; set; }
	}
}
