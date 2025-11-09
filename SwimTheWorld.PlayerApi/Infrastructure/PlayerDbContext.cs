using Microsoft.EntityFrameworkCore;
using SwimTheWorld.PlayerApi.Domain;

namespace SwimTheWorld.PlayerApi.Infrastructure;

public class PlayerDbContext : DbContext
{
    public PlayerDbContext(DbContextOptions<PlayerDbContext> options) : base(options)
    {
    }

    public DbSet<Player> Players { get; set; }
}
