using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Duyurular
	{
		[Key]
		public int DuyuruID { get; set; }
		public string DuyuruBaslik { get; set; }
		public string? DuyuruMekan { get; set; }
		public DateTime DuyuruTarih { get; set; }
	}
}
