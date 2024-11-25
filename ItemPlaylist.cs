﻿namespace StreamingAPI.Models
{
    public class ItemPlaylist
    {
        public int PlaylistID { get; set; }
        public int ConteudoID { get; set; }

        public Playlist Playlist { get; set; }
        public Conteudo Conteudo { get; set; }
    }
}