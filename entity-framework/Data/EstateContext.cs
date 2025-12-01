using Microsoft.EntityFrameworkCore;
using proj.Models;

namespace proj.Data;

public class EstateContext : DbContext
{
    public DbSet<Property> Properties => Set<Property>();
    public DbSet<Owner> Owners => Set<Owner>();
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Agent> Agents => Set<Agent>();
    public DbSet<Viewing> Viewings => Set<Viewing>();
    public DbSet<Contract> Contracts => Set<Contract>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5434;Database=estate;Username=postgres;Password=1111");
    }
}