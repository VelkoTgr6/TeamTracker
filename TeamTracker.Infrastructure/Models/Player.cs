using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TeamTracker.Infrastructure.Models
{
    public class Player
    {
        [Key]
        [Comment("Unique identifier for the player")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Comment("Name of the team")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Comment("Position of the team in the league")]
        public string Position { get; set; } = string.Empty;
        public IEnumerable<Score> ScoreHisotry { get; set; } = new List<Score>();
    }
}
