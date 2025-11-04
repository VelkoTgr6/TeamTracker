using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TeamTracker.Infrastructure.Models
{
    public class Team
    {
        [Key]
        [Comment("Unique identifier for the team")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Comment("Name of the team")]
        public string Name { get; set; } = string.Empty;

        [Comment("List of players in the team")]
        public virtual IEnumerable<Player> Players { get; set; } = new List<Player>();
    }
}
