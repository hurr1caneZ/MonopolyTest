using Microsoft.EntityFrameworkCore;
using Monopolia.Entities;

namespace Monopolia.DbContexts;

public class WareHouseContext : DbContext
{
    public DbSet<Pallet> Pallets { get; set; }
    public DbSet<Box> Boxes { get; set; }

    public WareHouseContext(DbContextOptions<WareHouseContext> options)
    : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Box>(b =>
        {
            b.Property(x => x.Id).ValueGeneratedOnAdd();
        });
        
        modelBuilder.Entity<Pallet>(b =>
        {
            b.Property(x => x.Id).ValueGeneratedOnAdd();
            b.HasMany(x => x.Boxes);
        });
    }
}