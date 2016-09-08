using Microsoft.EntityFrameworkCore;
using MvcMovie2.Models;

namespace MvcMovie2.Data
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Movie.db");
        }
    }
}