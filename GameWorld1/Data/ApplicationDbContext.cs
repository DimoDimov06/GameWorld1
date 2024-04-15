using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GameWorld1.Models;

namespace GameWorld1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GameWorld1.Models.Game> Game { get; set; } = default!;
        public DbSet<GameWorld1.Models.Catalogs> Catalogs { get; set; } = default!;
        public DbSet<GameWorld1.Models.CatalogGame> CatalogGame { get; set; } = default!;
        public DbSet<GameWorld1.Models.Users> Users { get; set; } = default!;
    }
}
