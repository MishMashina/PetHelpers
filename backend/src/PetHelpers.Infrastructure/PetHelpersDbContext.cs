using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PetHelpers.Domain.Models;

namespace PetHelpers.Infrastructure;

public class PetHelpersDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<Volunteer> Volunteers { get; set; }
    
    public PetHelpersDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql(_configuration.GetConnectionString("PetHelpersDbContext"))
            .UseSnakeCaseNamingConvention()
            .UseLoggerFactory(CreateLoggerFactory())
            .EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    private ILoggerFactory CreateLoggerFactory() => 
        LoggerFactory.Create(builder => builder.AddConsole());
}