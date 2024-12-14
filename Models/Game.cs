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

        [Column("GameRating", TypeName ="decimal(0,10)")]
        public decimal Rating { get; set; }
    }
}
