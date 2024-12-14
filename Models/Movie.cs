using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CodeFirst_1.Models
{
    [Table("Movies")]
    [Index(nameof(Title))]
    public class Movie
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("MovieName")]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        [Column("MovieGenre")]
        public string Genre { get; set; }

        [Required]
        [Column("MovieReleaseYear")]
        public int ReleaseYear  { get; set; }
    }
}
