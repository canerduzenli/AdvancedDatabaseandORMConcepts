using System.ComponentModel.DataAnnotations;

namespace AdvancedDatabaseandORMConcepts.Models
{
    public class Album
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Year { get; set; }

        public HashSet<Song> Songs { get; set; }
    }
}
