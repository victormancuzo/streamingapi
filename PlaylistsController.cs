using Microsoft.AspNetCore.Mvc;
using StreamingAPI.Models;
using StreamingAPI.Repositories;

[ApiController]
[Route("api/[controller]")]
public class PlaylistsController : ControllerBase
{
    private readonly PlaylistRepository _repository;

    public PlaylistsController(PlaylistRepository repository)
    {
        _repository = repository;
    }

    // GET: api/playlists
    [HttpGet]
    public IActionResult GetAll()
    {
        var playlists = _repository.GetAllPlaylists();
        return Ok(playlists);
    }

    // GET: api/playlists/{id}
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var playlist = _repository.GetPlaylistById(id);
        if (playlist == null)
        {
            return NotFound();
        }
        return Ok(playlist);
    }

    // POST: api/playlists
    [HttpPost]
    public IActionResult Create([FromBody] Playlist playlist)
    {
        if (playlist == null)
        {
            return BadRequest();
        }

        _repository.AddPlaylist(playlist);
        return CreatedAtAction(nameof(GetById), new { id = playlist.ID }, playlist);
    }

    // PUT: api/playlists/{id}
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Playlist playlist)
    {
        if (id != playlist.ID)
        {
            return BadRequest();
        }

        _repository.UpdatePlaylist(playlist);
        return NoContent(); // sem conteúdo, status "204"
    }

    // DELETE: api/playlists/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var playlist = _repository.GetPlaylistById(id);
        if (playlist == null)
        {
            return NotFound();
        }

        _repository.DeletePlaylist(id);
        return NoContent();
    }
}