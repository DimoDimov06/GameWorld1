using System.ComponentModel.DataAnnotations;

namespace GameWorld1.Models
{
    public class Game
    {
        [Key]
        public int GameID { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageUrl { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}