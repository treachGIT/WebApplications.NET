using LataPrzestepneIdentity.Data;
using LataPrzestepneIdentity.Models;

namespace LataPrzestepneIdentity.Repositories
{
    public class BirthdayRepository : IBirthdayRepository
    {
        private readonly ApplicationDbContext _context;

        public BirthdayRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Birthday birthday)
        {
             _context.Birthdays.Add(birthday);
             _context.SaveChanges();
        }

        public void Delete(Birthday birthday)
        {
            _context.Birthdays.Remove(birthday);
            _context.SaveChanges();
        }

        public IQueryable<Birthday> GetAllBirthdays()
        {
            return _context.Birthdays;
        }
    }
}
