using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class YtLink
    {
        [Key]
        public int YtId { get; set; } 
        public string YTUrl { get; set; } 

    }
}
