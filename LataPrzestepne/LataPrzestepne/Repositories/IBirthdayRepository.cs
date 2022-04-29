using LataPrzestepne.Models;

namespace LataPrzestepne.Repositories
{
    public interface IBirthdayRepository
    {
        Task AddAsync(Birthday birthday);
        Task DeleteAsync(Birthday birthday);
        IQueryable<Birthday> GetAllBirthdays();

    }
}
