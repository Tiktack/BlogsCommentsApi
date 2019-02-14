using Common;
using DataLayer.Entities;
using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class BaseContext : DbContext, IBaseContext
    {
        private readonly IAppSettings _appSettings;
        public BaseContext(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_appSettings.GetValue("ConnectionString"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}