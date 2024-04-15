using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameWorld1.Models
{
    public class CatalogGame
    {
        [Key]
        public int CatalogGameID { get; set; }

        [ForeignKey("Catalog")]
        public int CatalogID { get; set; }

        [ForeignKey("Game")]
        public int GameID { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }
    }
}