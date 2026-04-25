using Microsoft.EntityFrameworkCore;
using Models;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public required DbSet<UserModel> Users { get; set; }
}