using BlazorLite.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorLite.Data
{
    public class AppDataContext:DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}