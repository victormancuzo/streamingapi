namespace StreamingAPI.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
}