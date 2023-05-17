using EntityLayer.Concrete;
using System.Reflection.Metadata;

namespace AnaSinifi.Models
{
    public class AnasayfaModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<YtLink> YtLinks { get; set; }
    }
}
