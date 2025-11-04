using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamTracker.Infrastructure.Models
{
    public class Score
    {
        [Key]
        [Comment("Unique identifier for the score entry")]
        public int Id { get; set; }

        [Required]
        [Comment("Identifier of the player associated with this score entry")]
        public int PlayerId { get; set; }

        [ForeignKey("PlayerId")]
        [Comment("The player associated with this score entry")]
        public Player Player { get; set; } = null!;

        [Required]
        [Comment("Points scored by the team")]
        public int Points { get; set; }
    }
}
