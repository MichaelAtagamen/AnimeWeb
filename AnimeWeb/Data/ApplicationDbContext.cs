using AnimeWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Anime> Anime { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
}
