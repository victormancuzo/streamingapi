namespace StreamingAPI.Models
{
    public class Criador
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public ICollection<Conteudo> Conteudos { get; set; }
    }
}