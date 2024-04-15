using System.ComponentModel.DataAnnotations;

namespace GameWorld1.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [StringLength(64)]
        public string Username { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(30)]
        public string Role { get; set; } //(Admin or User)

    }
}