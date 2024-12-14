using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_1.Models
{
    [Table("Games")]
    [Index(nameof(Name))]
    public class Game
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("GameName")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Column("GamePlatform")]
        public string Platform  { get; set; }

        [Column("GameRating", TypeName ="decimal(3,1)")] // Used decimal(3,1) to store ratings between 0 and 10 with 1 decimal place.
        public decimal Rating { get; set; }
    }
}
