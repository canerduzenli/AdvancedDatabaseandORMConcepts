using System.ComponentModel.DataAnnotations;

namespace AdvancedDatabaseandORMConcepts.Models
{
    public class Playlist
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        public HashSet<Song> Songs { get; set; }
    }
}
