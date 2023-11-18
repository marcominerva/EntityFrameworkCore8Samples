using EntityFrameworkCore8Samples.Collections.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EntityFrameworkCore8Samples.Collections;

public partial class SampleDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Landmark> Landmarks { get; set; }

    public SampleDbContext()
    {
    }

    public SampleDbContext(DbContextOptions<SampleDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // add-migration ComplexType -Context EntityFrameworkCore8Samples.Collections.SampleDbContext
        modelBuilder.Entity<Landmark>(entity =>
        {
            entity.ComplexProperty(e => e.Position).IsRequired();    // La proprietà non può essere nullable
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SampleDB");
        optionsBuilder.LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted });
    }
}
