using Microsoft.EntityFrameworkCore;
using Revsite.Models;

namespace Revsite.Data
{
    public class RevsiteContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public RevsiteContext(DbContextOptions<RevsiteContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel
                {
                    uname = "admin",
                    pass = "admin",
                    Role = Models.Enum.UserRole.Admin
                }
            );
        }
    }
}
