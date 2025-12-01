using FootballGamePlan.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballGamePlan.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<GamePlan> GamePlans => Set<GamePlan>();
    public DbSet<Play> Plays => Set<Play>();
    public DbSet<PlayResult> PlayResults => Set<PlayResult>();

    
    

}
