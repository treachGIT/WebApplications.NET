using LataPrzestepne.Data;
using LataPrzestepne.Models;


namespace LataPrzestepne.Repositories
{
    public class BirthdayRepository : IBirthdayRepository
    {
        private readonly BirthdayContext _context;

        public BirthdayRepository(BirthdayContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Birthday birthday)
        {
            await _context.Birthdays.AddAsync(birthday);
            await _context.SaveChangesAsync();       
        }

        public async Task DeleteAsync(Birthday birthday)
        {
            _context.Birthdays.Remove(birthday);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Birthday> GetAllBirthdays()
        {
            return _context.Birthdays;      
        }
    }
}
