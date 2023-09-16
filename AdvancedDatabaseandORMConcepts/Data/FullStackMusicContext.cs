using AdvancedDatabaseandORMConcepts.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AdvancedDatabaseandORMConcepts.Data
{
    public class FullStackMusicContext : DbContext
    {
        public FullStackMusicContext(DbContextOptions<FullStackMusicContext> options) : base(options) { }
        public DbSet<Song> Songs { get; set; } = default!;
        public DbSet<Album> Albums { get; set; } = default!;
        public DbSet<Artist> Artists { get; set; } = default!;
        public DbSet<Playlist> Playlists { get; set; } = default!;
        public DbSet<SongArtists> SongsArtists { get; set; } = default!;

    }
}
