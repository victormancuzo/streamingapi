﻿namespace StreamingAPI.Models
{
    public class Playlist
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<ItemPlaylist> ItemPlaylists { get; set; }
    }
}