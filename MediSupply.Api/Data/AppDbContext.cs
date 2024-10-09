using MediSupply.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace MediSupply.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Area> Areas { get; set; }
    public DbSet<User> Users { get; set; }
}