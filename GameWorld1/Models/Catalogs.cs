using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameWorld1.Models
{
    public class Catalogs
    {
        [Key]
        public int CatalogID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [ForeignKey(nameof(CatalogID))]
        public int UserID { get; set; }

    }
}