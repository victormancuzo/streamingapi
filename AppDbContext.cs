﻿using Microsoft.EntityFrameworkCore;
using StreamingAPI.Models;

namespace StreamingAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Conteudo> Conteudos { get; set; }
        public DbSet<Criador> Criadores { get; set; }
    }
}