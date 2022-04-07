using LataPrzestepne.Models;
using Microsoft.EntityFrameworkCore;

namespace LataPrzestepne.Data
{
    public class BirthdayContext : DbContext
    {
        public BirthdayContext(DbContextOptions options) : base(options) { }

        public DbSet<Birthday> Birthdays { get; set; }
    }
}
