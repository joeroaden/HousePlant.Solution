using Microsoft.EntityFrameworkCore;

namespace HousePlant.Models
{
  public class HousePlantContext : DbContext
  {
    public HousePlantContext(DbContextOptions<HousePlantContext> options) : base(options)
    {
    }

    public DbSet<Plant> Plants { get; set; }
  }
}