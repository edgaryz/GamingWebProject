using GamingWebProject.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GamingWebProject.Core.Repositories
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=gaming_web_project;Integrated Security=True;TrustServerCertificate=true;");
        }

    }
}