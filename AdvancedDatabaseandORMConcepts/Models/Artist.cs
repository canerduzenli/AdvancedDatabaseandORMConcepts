using System.ComponentModel.DataAnnotations;

namespace AdvancedDatabaseandORMConcepts.Models
{
    public class Artist
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public HashSet<SongArtists> SongArtists { get; set; }
    }
}
