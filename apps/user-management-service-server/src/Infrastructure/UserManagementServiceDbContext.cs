using Microsoft.EntityFrameworkCore;
using UserManagementService.Infrastructure.Models;

namespace UserManagementService.Infrastructure;

public class UserManagementServiceDbContext : DbContext
{
    public UserManagementServiceDbContext(DbContextOptions<UserManagementServiceDbContext> options)
        : base(options) { }

    public DbSet<GuestDbModel> Guests { get; set; }

    public DbSet<UserDbModel> Users { get; set; }
}
