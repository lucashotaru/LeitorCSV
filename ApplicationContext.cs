using LeitorCBF.LeitorCSV.Models;
using Microsoft.EntityFrameworkCore;

namespace LeitorCBF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rodadas>().HasKey(t => t.Id);
        }
    }
}