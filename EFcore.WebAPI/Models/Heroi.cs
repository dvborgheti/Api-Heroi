using System.Text.Json.Serialization;

namespace EFcore.WebAPI.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Arma>? Armas { get; set; }
        public  List<HeroiBatalha>? HeroisBatalhas{ get; set; }

    }
}
