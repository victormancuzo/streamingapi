using StreamingAPI.Data;
using StreamingAPI.Models;

namespace StreamingAPI.Repositories
{
    public class PlaylistRepository
    {
        private readonly AppDbContext _context;

        public PlaylistRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Playlist> GetAllPlaylists()
        {
            return _context.Playlists.ToList();
        }

        public Playlist GetPlaylistById(int id)
        {
            return _context.Playlists.FirstOrDefault(p => p.ID == id);
        }

        public void AddPlaylist(Playlist playlist)
        {
            _context.Playlists.Add(playlist);
            _context.SaveChanges();
        }

        public void UpdatePlaylist(Playlist playlist)
        {
            _context.Playlists.Update(playlist);
            _context.SaveChanges();
        }

        public void DeletePlaylist(int id)
        {
            var playlist = _context.Playlists.FirstOrDefault(p => p.ID == id);
            if (playlist != null)
            {
                _context.Playlists.Remove(playlist);
                _context.SaveChanges();
            }
        }
    }
}